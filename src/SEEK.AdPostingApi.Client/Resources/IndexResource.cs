﻿using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SEEK.AdPostingApi.Client.Hal;
using SEEK.AdPostingApi.Client.Models;

namespace SEEK.AdPostingApi.Client.Resources
{
    [MediaType("application/hal+json")]
    public class IndexResource : IResource
    {
        private Hal.Client _client;

        [JsonIgnore]
        public Links Links { get; set; }

        [JsonIgnore]
        [FromHeader("X-Request-Id")]
        public string RequestId { get; set; }

        [JsonIgnore]
        public Uri Uri => this.Links.GenerateLink("self");

        public async Task<AdvertisementResource> CreateAdvertisementAsync(Advertisement advertisement)
        {
            return await this._client.PostResourceAsync<AdvertisementResource, Advertisement>(this.Links.GenerateLink("advertisements"), advertisement);
        }

        public Uri GenerateAdvertisementUri(Guid advertisementId)
        {
            return this.Links.GenerateLink("advertisement", new { advertisementId });
        }

        public async Task<AdvertisementSummaryPageResource> GetAllAdvertisements(string advertiserIdentifier = null)
        {
            return string.IsNullOrWhiteSpace(advertiserIdentifier)
                ? await this._client.GetResourceAsync<AdvertisementSummaryPageResource, AdvertisementErrorResponse>(
                    this.Links.GenerateLink("advertisements"))
                : await this._client.GetResourceAsync<AdvertisementSummaryPageResource, AdvertisementErrorResponse>(
                    this.Links.GenerateLink("advertisements", new { advertiserId = advertiserIdentifier }));
        }

        public async Task<TemplateSummaryListResource> GetAllTemplates(long? advertiserIdentifier = null, DateTimeOffset? fromDateTimeUtc = null)
        {
            return !advertiserIdentifier.HasValue
                ? await this._client.GetResourceAsync<TemplateSummaryListResource, TemplateErrorResponse>(
                    this.Links.GenerateLink("templates", new
                    {
                        fromDateTimeUtc = fromDateTimeUtc.HasValue ? $"{fromDateTimeUtc:yyyy-MM-ddTHH:mm:ssZ}" : null,
                    }))
                : await this._client.GetResourceAsync<TemplateSummaryListResource, TemplateErrorResponse>(
                    this.Links.GenerateLink("templates", new
                    {
                        advertiserId = advertiserIdentifier,
                        fromDateTimeUtc = fromDateTimeUtc.HasValue ? $"{fromDateTimeUtc:yyyy-MM-ddTHH:mm:ssZ}" : null,
                    }));
        }

        public void Initialise(Hal.Client client)
        {
            this._client = client;
        }
    }
}