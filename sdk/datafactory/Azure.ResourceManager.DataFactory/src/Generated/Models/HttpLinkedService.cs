// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Linked service for an HTTP source. </summary>
    public partial class HttpLinkedService : DataFactoryLinkedServiceDefinition
    {
        /// <summary> Initializes a new instance of HttpLinkedService. </summary>
        /// <param name="uri"> The base URL of the HTTP endpoint, e.g. https://www.microsoft.com. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public HttpLinkedService(DataFactoryElement<string> uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            Uri = uri;
            LinkedServiceType = "HttpServer";
        }

        /// <summary> Initializes a new instance of HttpLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="uri"> The base URL of the HTTP endpoint, e.g. https://www.microsoft.com. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> The authentication type to be used to connect to the HTTP server. </param>
        /// <param name="userName"> User name for Basic, Digest, or Windows authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// Password for Basic, Digest, Windows, or ClientCertificate with EmbeddedCertData authentication.
        /// Please note <see cref="DataFactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataFactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <param name="authHeaders"> The additional HTTP headers in the request to RESTful API used for authorization. Type: object (or Expression with resultType object). </param>
        /// <param name="embeddedCertData"> Base64 encoded certificate data for ClientCertificate authentication. For on-premises copy with ClientCertificate authentication, either CertThumbprint or EmbeddedCertData/Password should be specified. Type: string (or Expression with resultType string). </param>
        /// <param name="certThumbprint"> Thumbprint of certificate for ClientCertificate authentication. Only valid for on-premises copy. For on-premises copy with ClientCertificate authentication, either CertThumbprint or EmbeddedCertData/Password should be specified. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        /// <param name="enableServerCertificateValidation"> If true, validate the HTTPS server SSL certificate. Default value is true. Type: boolean (or Expression with resultType boolean). </param>
        internal HttpLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> uri, HttpAuthenticationType? authenticationType, DataFactoryElement<string> userName, DataFactorySecretBaseDefinition password, DataFactoryElement<BinaryData> authHeaders, DataFactoryElement<string> embeddedCertData, DataFactoryElement<string> certThumbprint, BinaryData encryptedCredential, DataFactoryElement<bool> enableServerCertificateValidation) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Uri = uri;
            AuthenticationType = authenticationType;
            UserName = userName;
            Password = password;
            AuthHeaders = authHeaders;
            EmbeddedCertData = embeddedCertData;
            CertThumbprint = certThumbprint;
            EncryptedCredential = encryptedCredential;
            EnableServerCertificateValidation = enableServerCertificateValidation;
            LinkedServiceType = linkedServiceType ?? "HttpServer";
        }

        /// <summary> The base URL of the HTTP endpoint, e.g. https://www.microsoft.com. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Uri { get; set; }
        /// <summary> The authentication type to be used to connect to the HTTP server. </summary>
        public HttpAuthenticationType? AuthenticationType { get; set; }
        /// <summary> User name for Basic, Digest, or Windows authentication. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary>
        /// Password for Basic, Digest, Windows, or ClientCertificate with EmbeddedCertData authentication.
        /// Please note <see cref="DataFactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataFactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
        /// <summary> The additional HTTP headers in the request to RESTful API used for authorization. Type: object (or Expression with resultType object). </summary>
        public DataFactoryElement<BinaryData> AuthHeaders { get; set; }
        /// <summary> Base64 encoded certificate data for ClientCertificate authentication. For on-premises copy with ClientCertificate authentication, either CertThumbprint or EmbeddedCertData/Password should be specified. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> EmbeddedCertData { get; set; }
        /// <summary> Thumbprint of certificate for ClientCertificate authentication. Only valid for on-premises copy. For on-premises copy with ClientCertificate authentication, either CertThumbprint or EmbeddedCertData/Password should be specified. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> CertThumbprint { get; set; }
        /// <summary>
        /// The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData EncryptedCredential { get; set; }
        /// <summary> If true, validate the HTTPS server SSL certificate. Default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public DataFactoryElement<bool> EnableServerCertificateValidation { get; set; }
    }
}
