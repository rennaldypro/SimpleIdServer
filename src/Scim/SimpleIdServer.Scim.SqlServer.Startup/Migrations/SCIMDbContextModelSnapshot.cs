﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleIdServer.Scim.Persistence.EF;

#nullable disable

namespace SimpleIdServer.Scim.SqlServer.Startup.Migrations
{
    [DbContext(typeof(SCIMDbContext))]
    partial class SCIMDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("scim")
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SCIMRepresentationSCIMSchema", b =>
                {
                    b.Property<string>("RepresentationsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SchemasId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RepresentationsId", "SchemasId");

                    b.HasIndex("SchemasId");

                    b.ToTable("SCIMRepresentationSCIMSchema", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.ProvisioningConfiguration", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ResourceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProvisioningConfigurations", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.ProvisioningConfigurationHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exception")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExecutionDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProvisioningConfigurationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RepresentationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RepresentationVersion")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("WorkflowId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkflowInstanceId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProvisioningConfigurationId");

                    b.ToTable("ProvisioningConfigurationHistory", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.ProvisioningConfigurationRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsArray")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvisioningConfigurationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ProvisioningConfigurationRecordId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("ValuesString")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProvisioningConfigurationId");

                    b.HasIndex("ProvisioningConfigurationRecordId");

                    b.ToTable("ProvisioningConfigurationRecord", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMAttributeMapping", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Mode")
                        .HasColumnType("int");

                    b.Property<string>("SourceAttributeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceAttributeSelector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceResourceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TargetAttributeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TargetResourceType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SCIMAttributeMappingLst", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMRepresentation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResourceType")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SCIMRepresentationLst", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMRepresentationAttribute", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AttributeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Namespace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentAttributeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RepresentationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ResourceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchemaAttributeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ValueBinary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("ValueBoolean")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ValueDateTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("ValueDecimal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ValueInteger")
                        .HasColumnType("int");

                    b.Property<string>("ValueReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValueString")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ParentAttributeId");

                    b.HasIndex("RepresentationId");

                    b.HasIndex("SchemaAttributeId");

                    b.ToTable("SCIMRepresentationAttributeLst", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMSchema", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRootSchema")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResourceType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SCIMSchemaLst", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMSchemaAttribute", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CanonicalValues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CaseExact")
                        .HasColumnType("bit");

                    b.Property<string>("DefaultValueInt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DefaultValueString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MultiValued")
                        .HasColumnType("bit");

                    b.Property<int>("Mutability")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceTypes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Required")
                        .HasColumnType("bit");

                    b.Property<int>("Returned")
                        .HasColumnType("int");

                    b.Property<string>("SchemaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("Uniqueness")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SchemaId");

                    b.ToTable("SCIMSchemaAttribute", "scim");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMSchemaExtension", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Required")
                        .HasColumnType("bit");

                    b.Property<string>("SCIMSchemaId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Schema")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SCIMSchemaId");

                    b.ToTable("SCIMSchemaExtension", "scim");
                });

            modelBuilder.Entity("SCIMRepresentationSCIMSchema", b =>
                {
                    b.HasOne("SimpleIdServer.Scim.Domains.SCIMRepresentation", null)
                        .WithMany()
                        .HasForeignKey("RepresentationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SimpleIdServer.Scim.Domains.SCIMSchema", null)
                        .WithMany()
                        .HasForeignKey("SchemasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.ProvisioningConfigurationHistory", b =>
                {
                    b.HasOne("SimpleIdServer.Scim.Domains.ProvisioningConfiguration", "ProvisioningConfiguration")
                        .WithMany("HistoryLst")
                        .HasForeignKey("ProvisioningConfigurationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("ProvisioningConfiguration");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.ProvisioningConfigurationRecord", b =>
                {
                    b.HasOne("SimpleIdServer.Scim.Domains.ProvisioningConfiguration", null)
                        .WithMany("Records")
                        .HasForeignKey("ProvisioningConfigurationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleIdServer.Scim.Domains.ProvisioningConfigurationRecord", null)
                        .WithMany("Values")
                        .HasForeignKey("ProvisioningConfigurationRecordId");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMRepresentationAttribute", b =>
                {
                    b.HasOne("SimpleIdServer.Scim.Domains.SCIMRepresentationAttribute", null)
                        .WithMany("Children")
                        .HasForeignKey("ParentAttributeId");

                    b.HasOne("SimpleIdServer.Scim.Domains.SCIMRepresentation", "Representation")
                        .WithMany("FlatAttributes")
                        .HasForeignKey("RepresentationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SimpleIdServer.Scim.Domains.SCIMSchemaAttribute", "SchemaAttribute")
                        .WithMany()
                        .HasForeignKey("SchemaAttributeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Representation");

                    b.Navigation("SchemaAttribute");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMSchemaAttribute", b =>
                {
                    b.HasOne("SimpleIdServer.Scim.Domains.SCIMSchema", null)
                        .WithMany("Attributes")
                        .HasForeignKey("SchemaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMSchemaExtension", b =>
                {
                    b.HasOne("SimpleIdServer.Scim.Domains.SCIMSchema", null)
                        .WithMany("SchemaExtensions")
                        .HasForeignKey("SCIMSchemaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.ProvisioningConfiguration", b =>
                {
                    b.Navigation("HistoryLst");

                    b.Navigation("Records");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.ProvisioningConfigurationRecord", b =>
                {
                    b.Navigation("Values");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMRepresentation", b =>
                {
                    b.Navigation("FlatAttributes");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMRepresentationAttribute", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("SimpleIdServer.Scim.Domains.SCIMSchema", b =>
                {
                    b.Navigation("Attributes");

                    b.Navigation("SchemaExtensions");
                });
#pragma warning restore 612, 618
        }
    }
}
