﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using Microsoft.IdentityModel.Tokens;
using SimpleIdServer.IdServer.Domains;

namespace SimpleIdServer.IdServer.Builders
{
    public class UserAgentClientBuilder
    {
        private readonly Client _client;

        internal UserAgentClientBuilder(Client client) { _client = client; }

        public UserAgentClientBuilder AddScope(params string[] scopes)
        {
            foreach (var scope in scopes) _client.Scopes.Add(new Scope { Name = scope });
            return this;
        }

        public UserAgentClientBuilder DisableIdTokenSignature()
        {
            _client.IdTokenSignedResponseAlg = SecurityAlgorithms.None;
            return this;
        }

        public UserAgentClientBuilder SetIdTokenSignatureAlg(string alg)
        {
            _client.IdTokenSignedResponseAlg = alg;
            return this;
        }

        public UserAgentClientBuilder SetIdTokenEncryption(string alg, string enc)
        {
            _client.IdTokenEncryptedResponseAlg= alg;
            _client.IdTokenEncryptedResponseEnc = enc;
            return this;
        }

        public UserAgentClientBuilder AddEncryptedKey(EncryptingCredentials credentials)
        {
            var jsonWebKey = credentials.SerializePublicJWK();
            jsonWebKey.Alg = credentials.Alg;
            _client.Add(credentials.Key.KeyId, jsonWebKey);
            return this;
        }

        public UserAgentClientBuilder AddRSAEncryptedKey(RsaSecurityKey rsa, string alg, string enc) => AddEncryptedKey(new EncryptingCredentials(rsa, alg, enc));

        public Client Build() => _client;
    }
}
