﻿using SEEK.AdPostingApi.Client.Models;

namespace SEEK.AdPostingApi.SampleConsumer.Tests
{
    public class MinimumFieldsInitializer : IBuilderInitializer
    {
        public void Initialize(AdvertisementContentBuilder builder)
        {
            builder
                .WithAdvertiserId(GetDefaultAdvertiserId())
                .WithAdvertisementType(AdvertisementType.Classic.ToString())
                .WithJobTitle(GetDefaultJobTitle())
                .WithLocationId(GetDefaultLocationId())
                .WithSubclassificationId(GetDefaultSubclassificationId())
                .WithWorkType(GetDefaultWorkType().ToString())
                .WithSalaryType(GetDefaultSalaryType().ToString())
                .WithSalaryMinimum(GetDefaultSalaryMinimum())
                .WithSalaryMaximum(GetDefaultSalaryMaximum())
                .WithJobSummary(GetDefaultJobSummary())
                .WithAdvertisementDetails(GetDefaultAdvertisementDetails());
        }

        public void Initialize(AdvertisementModelBuilder builder)
        {
            builder
                .WithAdvertiserId(GetDefaultAdvertiserId())
                .WithAdvertisementType(AdvertisementType.Classic)
                .WithJobTitle(GetDefaultJobTitle())
                .WithLocationId(GetDefaultLocationId())
                .WithSubclassificationId(GetDefaultSubclassificationId())
                .WithWorkType(GetDefaultWorkType())
                .WithSalaryType(GetDefaultSalaryType())
                .WithSalaryMinimum(GetDefaultSalaryMinimum())
                .WithSalaryMaximum(GetDefaultSalaryMaximum())
                .WithJobSummary(GetDefaultJobSummary())
                .WithAdvertisementDetails(GetDefaultAdvertisementDetails());
        }

        private string GetDefaultAdvertiserId()
        {
            return "9012";
        }

        private string GetDefaultJobTitle()
        {
            return "Exciting Senior Developer role in a great CBD location. Great $$$";
        }

        private string GetDefaultJobSummary()
        {
            return "Developer job";
        }

        private string GetDefaultAdvertisementDetails()
        {
            return "Exciting, do I need to say more?";
        }

        private string GetDefaultLocationId()
        {
            return "378";
        }

        private string GetDefaultSubclassificationId()
        {
            return "734";
        }

        private WorkType GetDefaultWorkType()
        {
            return WorkType.FullTime;
        }

        private SalaryType GetDefaultSalaryType()
        {
            return SalaryType.AnnualPackage;
        }

        private int GetDefaultSalaryMinimum()
        {
            return 100000;
        }

        private int GetDefaultSalaryMaximum()
        {
            return 200000;
        }
    }
}