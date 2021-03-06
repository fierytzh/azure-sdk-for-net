// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.TextAnalytics
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The Text Analytics API is a suite of text analytics web services built
    /// with best-in-class Microsoft machine learning algorithms. The API can
    /// be used to analyze unstructured text for tasks such as sentiment
    /// analysis, key phrase extraction and language detection. No training
    /// data is needed to use this API; just bring your text data. This API
    /// uses advanced natural language processing techniques to deliver best in
    /// class predictions. Further documentation can be found in
    /// https://docs.microsoft.com/en-us/azure/cognitive-services/text-analytics/overview
    /// </summary>
    public partial interface ITextAnalyticsAPI : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
        /// 'westcentralus', 'westus2', 'eastus', 'southcentralus',
        /// 'northeurope', 'eastasia', 'australiaeast', 'brazilsouth',
        /// 'canadacentral', 'centralindia', 'uksouth', 'japaneast'
        /// </summary>
        AzureRegions AzureRegion { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// The API returns a list of strings denoting the key talking points
        /// in the input text.
        /// </summary>
        /// <remarks>
        /// See the &lt;a
        /// href="https://docs.microsoft.com/en-us/azure/cognitive-services/text-analytics/overview#supported-languages"&gt;Text
        /// Analytics Documentation&lt;/a&gt; for details about the languages
        /// that are supported by key phrase extraction.
        /// </remarks>
        /// <param name='input'>
        /// Collection of documents to analyze. Documents can now contain a
        /// language field to indicate the text language
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<KeyPhraseBatchResult>> KeyPhrasesWithHttpMessagesAsync(MultiLanguageBatchInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// The API returns the detected language and a numeric score between 0
        /// and 1.
        /// </summary>
        /// <remarks>
        /// Scores close to 1 indicate 100% certainty that the identified
        /// language is true. A total of 120 languages are supported.
        /// </remarks>
        /// <param name='input'>
        /// Collection of documents to analyze.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<LanguageBatchResult>> DetectLanguageWithHttpMessagesAsync(BatchInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// The API returns a numeric score between 0 and 1.
        /// </summary>
        /// <remarks>
        /// Scores close to 1 indicate positive sentiment, while scores close
        /// to 0 indicate negative sentiment. A score of 0.5 indicates the lack
        /// of sentiment (e.g. a factoid statement). See the &lt;a
        /// href="https://docs.microsoft.com/en-us/azure/cognitive-services/text-analytics/overview#supported-languages"&gt;Text
        /// Analytics Documentation&lt;/a&gt; for details about the languages
        /// that are supported by sentiment analysis.
        /// </remarks>
        /// <param name='input'>
        /// Collection of documents to analyze.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<SentimentBatchResult>> SentimentWithHttpMessagesAsync(MultiLanguageBatchInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// The API returns a list of recognized entities in a given document.
        /// </summary>
        /// <remarks>
        /// To get even more information on each recognized entity we recommend
        /// using the Bing Entity Search API by querying for the recognized
        /// entities names. See the &lt;a
        /// href="https://docs.microsoft.com/en-us/azure/cognitive-services/text-analytics/text-analytics-supported-languages"&gt;Supported
        /// languages in Text Analytics API&lt;/a&gt; for the list of enabled
        /// languages.
        /// </remarks>
        /// <param name='input'>
        /// Collection of documents to analyze.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<EntitiesBatchResult>> EntitiesWithHttpMessagesAsync(MultiLanguageBatchInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
