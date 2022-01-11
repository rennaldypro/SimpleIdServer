@model SimpleIdServer.Uma.UI.ViewModels.RequestsReceivedViewModel
@using Microsoft.AspNetCore.Localization
@using Microsoft.AspNetCore.Mvc.Localization
@inject IViewLocalizer Localizer

@{
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = Localizer["my_received_requests_title"];
    var requestCulture = Context.Features.Get<IRequestCultureFeature>();
}

<div class="container">
    <h1>@Localizer["my_received_requests_title"]</h1>
    <table class="table table-striped table-bordered" id="received-requests">
        <thead>
            <tr>
                <th>@Localizer["requester"]</th>
                <th>@Localizer["resource"]</th>
                <th>@Localizer["scopes"]</th>
                <th>@Localizer["creation_datetime"]</th>
                <th></th>
            </tr>
        </thead>
        <tbody></tbody>
    </table>
</div>

@section Scripts {
    <script type="text/javascript">
        $(document).ready(function() {
            let currentCultureKey = "@requestCulture.RequestCulture.UICulture.Name";
            let confirmRequestUrl = "@Url.Action("Confirm", "RequestsAPI", new { id = "{0}" })";
            let rejectRequestUrl = "@Url.Action("Reject", "RequestsAPI", new { id = "{0}" })";
            let table = $("#received-requests").DataTable({
                "processing": true,
                "serverSide": true,
                "searching": false,
                "ajax": {
                    "url": "@Url.Action("SearchReceivedRequests", "RequestsAPI")",
                    "type": "GET",
                    "data": function (d) {
                        let orderColumnSort = d.order[0].dir;
                        let orderColumnIndex = d.order[0].column;
                        let orderColumnName = d.columns[orderColumnIndex].name;
                        var query = "start_index=" + d.start + "&count=" + d.length + "&sort=" + orderColumnName + "&order=" + orderColumnSort;
                        return query;
                    },
                    "beforeSend": function (xhr) {
                        xhr.setRequestHeader("Authorization", "@Model.IdToken");
                    },
                    "dataFilter": function (inData) {
                        let json = JSON.parse(inData);
                        let newData = [];
                        json.data.forEach(function (jObj) {
                            var newObj = [];
                            let resource = jObj["resource"];
                            let name = "";
                            for (let resourceKey in resource) {
                                if (resourceKey.startsWith('name')) {
                                    let splittedKey = resourceKey.split('#');
                                    if (splittedKey[1] === currentCultureKey) {
                                        name = resource[resourceKey];
                                    }
                                }
                            }

                            newObj.push(jObj["requester"]);
                            newObj.push(name);
                            newObj.push(jObj["scopes"].join());
                            newObj.push(jObj["create_datetime"]);
                            newObj.push({ ticket: jObj["ticket"], status: jObj["status"] });
                            newData.push(newObj);
                        });
                        var result = {
                            data: newData,
                            recordsTotal: json.totalResults,
                            recordsFiltered: json.totalResults
                        };
                        return JSON.stringify(result);
                    }
                },
                "columnDefs": [
                    { "name": "Requester", targets: 0, orderable: false },
                    { "name": "Resource", targets: 1, orderable: false },
                    { "name": "Scopes", targets: 2, orderable: false },
                    { "name": "CreateDateTime", targets: 3 },
                    {
                        "name": "Action", targets: 4, orderable: false, render: function (data) {
                            if (data.status === 'tobeconfirmed') {
                                let confirmUrl = confirmRequestUrl.replace("%7B0%7D", data.ticket);
                                let rejectUrl = rejectRequestUrl.replace("%7B0%7D", data.ticket);
                                return "<a href='" + confirmUrl + "' class='btn btn-success accept'>@Localizer["accept"]</a>" +
                                    "<a href= '" + rejectUrl + "' class='btn btn-danger reject'>@Localizer["reject"]</a>";
                            }

                            if (data.status === 'confirmed') {
                                return "<span class='badge badge-success'>@Localizer["confirmed"]</span>";
                            }

                            return "<span class='badge badge-success'>@Localizer["rejected"]</span>";
                        }
                    }
                ],
                "order": [[3, "desc"]]
            });

            $("#received-requests tbody").on('click', 'a.accept', function (e) {
                e.preventDefault();
                let href = $(this).attr('href');
                $.ajax({
                    "type": "GET",
                    "url": href,
                    "beforeSend": function (xhr) {
                        xhr.setRequestHeader("Authorization", "@Model.IdToken");
                    },
                    "success": function () {
                        table.ajax.reload();
                    }
                });
            });

            $("#received-requests tbody").on('click', 'a.reject', function () {
                let href = $(this).attr('href');
                $.ajax({
                    "type": "DELETE",
                    "url": href,
                    "beforeSend": function (xhr) {
                        xhr.setRequestHeader("Authorization", "@Model.IdToken");
                    },
                    "success": function () {
                        table.ajax.reload();
                    }
                });
            });
        })
    </script>
}