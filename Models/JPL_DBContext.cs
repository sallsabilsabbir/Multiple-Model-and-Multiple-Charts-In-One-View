using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MultipleModelandMultipleChartsInOneView.Models
{
    public partial class JPL_DBContext : DbContext
    {
        public JPL_DBContext()
        {
        }

        public JPL_DBContext(DbContextOptions<JPL_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbcTable> AbcTables { get; set; } = null!;
        public virtual DbSet<AmbentTemperature> AmbentTemperatures { get; set; } = null!;
        public virtual DbSet<CumulativePoaAvg> CumulativePoaAvgs { get; set; } = null!;
        public virtual DbSet<CumulatuivePr> CumulatuivePrs { get; set; } = null!;
        public virtual DbSet<InverterAcPower> InverterAcPowers { get; set; } = null!;
        public virtual DbSet<InverterDcPower> InverterDcPowers { get; set; } = null!;
        public virtual DbSet<InverterEfficiency> InverterEfficiencies { get; set; } = null!;
        public virtual DbSet<InverterTotalAcPower> InverterTotalAcPowers { get; set; } = null!;
        public virtual DbSet<InverterTotalDcPower> InverterTotalDcPowers { get; set; } = null!;
        public virtual DbSet<LifetimeGeneration> LifetimeGenerations { get; set; } = null!;
        public virtual DbSet<LivePower> LivePowers { get; set; } = null!;
        public virtual DbSet<MaxAcPower> MaxAcPowers { get; set; } = null!;
        public virtual DbSet<MaxDcPower> MaxDcPowers { get; set; } = null!;
        public virtual DbSet<ModuleTemperature> ModuleTemperatures { get; set; } = null!;
        public virtual DbSet<PlantDatum> PlantData { get; set; } = null!;
        public virtual DbSet<PoaAvg> PoaAvgs { get; set; } = null!;
        public virtual DbSet<Pr> Prs { get; set; } = null!;
        public virtual DbSet<SavingsAndProfit> SavingsAndProfits { get; set; } = null!;
        public virtual DbSet<ShedWiseGenerationGraph> ShedWiseGenerationGraphs { get; set; } = null!;
        public virtual DbSet<ShedWiseTodaysEnergy> ShedWiseTodaysEnergies { get; set; } = null!;
        public virtual DbSet<ShedWiseYesterdaysEnergy> ShedWiseYesterdaysEnergies { get; set; } = null!;
        public virtual DbSet<TodayPlantTotalEnergy> TodayPlantTotalEnergies { get; set; } = null!;
        public virtual DbSet<TodaysDatum> TodaysData { get; set; } = null!;
        public virtual DbSet<TodaysGeneration> TodaysGenerations { get; set; } = null!;
        public virtual DbSet<TotalAcPower> TotalAcPowers { get; set; } = null!;
        public virtual DbSet<TotalDcPower> TotalDcPowers { get; set; } = null!;
        public virtual DbSet<TotalGeneration> TotalGenerations { get; set; } = null!;
        public virtual DbSet<TotalGenerationForAllInverrter> TotalGenerationForAllInverrters { get; set; } = null!;
        public virtual DbSet<TotalMaxAcPower> TotalMaxAcPowers { get; set; } = null!;
        public virtual DbSet<TotalMaxDcPower> TotalMaxDcPowers { get; set; } = null!;
        public virtual DbSet<TotalPr> TotalPrs { get; set; } = null!;
        public virtual DbSet<YesterdayPlantTotalEnergy> YesterdayPlantTotalEnergies { get; set; } = null!;
        public virtual DbSet<YesterdaysDatum> YesterdaysData { get; set; } = null!;
        public virtual DbSet<YesterdaysGeneration> YesterdaysGenerations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbcTable>(entity =>
            {
                entity.ToTable("AbcTable");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.TestValueTwo).HasMaxLength(50);
            });

            modelBuilder.Entity<AmbentTemperature>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ambent_Temperature");

                entity.Property(e => e.AmbentTemperature1).HasColumnName("Ambent_Temperature");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<CumulativePoaAvg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cumulative_POA_AVG");

                entity.Property(e => e.CumulativePoaAvg1).HasColumnName("Cumulative_POA_AVG");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<CumulatuivePr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cumulatuive_PR");

                entity.Property(e => e.CumulatuivePr1).HasColumnName("Cumulatuive_PR");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<InverterAcPower>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Inverter_AC_Power");

                entity.Property(e => e.Shed1).HasColumnName("Shed_1");

                entity.Property(e => e.Shed10).HasColumnName("Shed_10");

                entity.Property(e => e.Shed11).HasColumnName("Shed_11");

                entity.Property(e => e.Shed12).HasColumnName("Shed_12");

                entity.Property(e => e.Shed2).HasColumnName("Shed_2");

                entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");

                entity.Property(e => e.Shed5).HasColumnName("Shed_5");

                entity.Property(e => e.Shed6).HasColumnName("Shed_6");

                entity.Property(e => e.Shed7).HasColumnName("Shed_7");

                entity.Property(e => e.Shed8).HasColumnName("Shed_8");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<InverterDcPower>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Inverter_DC_Power");

                entity.Property(e => e.Shed1).HasColumnName("Shed_1");

                entity.Property(e => e.Shed10).HasColumnName("Shed_10");

                entity.Property(e => e.Shed11).HasColumnName("Shed_11");

                entity.Property(e => e.Shed12).HasColumnName("Shed_12");

                entity.Property(e => e.Shed2).HasColumnName("Shed_2");

                entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");

                entity.Property(e => e.Shed5).HasColumnName("Shed_5");

                entity.Property(e => e.Shed6).HasColumnName("Shed_6");

                entity.Property(e => e.Shed7).HasColumnName("Shed_7");

                entity.Property(e => e.Shed8).HasColumnName("Shed_8");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<InverterEfficiency>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Inverter_Efficiency");

                entity.Property(e => e.Shed1).HasColumnName("Shed_1");

                entity.Property(e => e.Shed10).HasColumnName("Shed_10");

                entity.Property(e => e.Shed11).HasColumnName("Shed_11");

                entity.Property(e => e.Shed12).HasColumnName("Shed_12");

                entity.Property(e => e.Shed2).HasColumnName("Shed_2");

                entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");

                entity.Property(e => e.Shed5).HasColumnName("Shed_5");

                entity.Property(e => e.Shed6).HasColumnName("Shed_6");

                entity.Property(e => e.Shed7).HasColumnName("Shed_7");

                entity.Property(e => e.Shed8).HasColumnName("Shed_8");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<InverterTotalAcPower>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Inverter_Total_AC_Power");

                entity.Property(e => e.InverterTotalAcPower1).HasColumnName("InverterTotal_AC_Power");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<InverterTotalDcPower>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Inverter_Total_DC_Power");

                entity.Property(e => e.InverterTotalDcPower1).HasColumnName("InverterTotal_DC_Power");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<LifetimeGeneration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Lifetime_Generation");

                entity.Property(e => e.LifetimeGeneration1).HasColumnName("Lifetime_Generation");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<LivePower>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LivePower");

                entity.Property(e => e.LivePower1).HasColumnName("Live_Power");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<MaxAcPower>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Max_AC_Power");

                entity.Property(e => e.Shed1).HasColumnName("Shed_1");

                entity.Property(e => e.Shed10).HasColumnName("Shed_10");

                entity.Property(e => e.Shed11).HasColumnName("Shed_11");

                entity.Property(e => e.Shed12).HasColumnName("Shed_12");

                entity.Property(e => e.Shed2).HasColumnName("Shed_2");

                entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");

                entity.Property(e => e.Shed5).HasColumnName("Shed_5");

                entity.Property(e => e.Shed6).HasColumnName("Shed_6");

                entity.Property(e => e.Shed7).HasColumnName("Shed_7");

                entity.Property(e => e.Shed8).HasColumnName("Shed_8");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<MaxDcPower>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Max_DC_Power");

                entity.Property(e => e.Shed1).HasColumnName("Shed_1");

                entity.Property(e => e.Shed10).HasColumnName("Shed_10");

                entity.Property(e => e.Shed11).HasColumnName("Shed_11");

                entity.Property(e => e.Shed12).HasColumnName("Shed_12");

                entity.Property(e => e.Shed2).HasColumnName("Shed_2");

                entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");

                entity.Property(e => e.Shed5).HasColumnName("Shed_5");

                entity.Property(e => e.Shed6).HasColumnName("Shed_6");

                entity.Property(e => e.Shed7).HasColumnName("Shed_7");

                entity.Property(e => e.Shed8).HasColumnName("Shed_8");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<ModuleTemperature>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Module_Temperature");

                entity.Property(e => e.ModuleTemperature1).HasColumnName("Module_Temperature");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<PlantDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Plant_Data");

                entity.Property(e => e.PlantNetGeneration).HasColumnName("Plant_Net_Generation");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.TodayExport).HasColumnName("Today_Export");

                entity.Property(e => e.TodayImport).HasColumnName("Today_Import");

                entity.Property(e => e.TodayNetGeneration).HasColumnName("Today_Net_Generation");
            });

            modelBuilder.Entity<PoaAvg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Poa_Avg");

                entity.Property(e => e.PoaAvg1).HasColumnName("Poa_Avg");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<Pr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PR");

                entity.Property(e => e.Shed1).HasColumnName("Shed_1");

                entity.Property(e => e.Shed10).HasColumnName("Shed_10");

                entity.Property(e => e.Shed11).HasColumnName("Shed_11");

                entity.Property(e => e.Shed12).HasColumnName("Shed_12");

                entity.Property(e => e.Shed2).HasColumnName("Shed_2");

                entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");

                entity.Property(e => e.Shed5).HasColumnName("Shed_5");

                entity.Property(e => e.Shed6).HasColumnName("Shed_6");

                entity.Property(e => e.Shed7).HasColumnName("Shed_7");

                entity.Property(e => e.Shed8).HasColumnName("Shed_8");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<SavingsAndProfit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Savings_and_Profit");

                entity.Property(e => e.Co2Savings).HasColumnName("CO2_Savings");

                entity.Property(e => e.GrossProfit).HasColumnName("Gross_Profit");

                entity.Property(e => e.RobintexSavings).HasColumnName("Robintex_Savings");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShedWiseGenerationGraph>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Shed_Wise_Generation_Graph");

                entity.Property(e => e.Shed1).HasColumnName("Shed_1");

                entity.Property(e => e.Shed10).HasColumnName("Shed_10");

                entity.Property(e => e.Shed11).HasColumnName("Shed_11");

                entity.Property(e => e.Shed12).HasColumnName("Shed_12");

                entity.Property(e => e.Shed2).HasColumnName("Shed_2");

                entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");

                entity.Property(e => e.Shed5).HasColumnName("Shed_5");

                entity.Property(e => e.Shed6).HasColumnName("Shed_6");

                entity.Property(e => e.Shed7).HasColumnName("Shed_7");

                entity.Property(e => e.Shed8).HasColumnName("Shed_8");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShedWiseTodaysEnergy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ShedWise_TodaysEnergy");

                entity.Property(e => e.Shed1).HasColumnName("Shed_1");

                entity.Property(e => e.Shed10).HasColumnName("Shed_10");

                entity.Property(e => e.Shed11).HasColumnName("Shed_11");

                entity.Property(e => e.Shed12).HasColumnName("Shed_12");

                entity.Property(e => e.Shed2).HasColumnName("Shed_2");

                entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");

                entity.Property(e => e.Shed5).HasColumnName("Shed_5");

                entity.Property(e => e.Shed6).HasColumnName("Shed_6");

                entity.Property(e => e.Shed7).HasColumnName("Shed_7");

                entity.Property(e => e.Shed8).HasColumnName("Shed_8");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<ShedWiseYesterdaysEnergy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ShedWise_YesterdaysEnergy");

                entity.Property(e => e.Shed1).HasColumnName("Shed_1");

                entity.Property(e => e.Shed10).HasColumnName("Shed_10");

                entity.Property(e => e.Shed11).HasColumnName("Shed_11");

                entity.Property(e => e.Shed12).HasColumnName("Shed_12");

                entity.Property(e => e.Shed2).HasColumnName("Shed_2");

                entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");

                entity.Property(e => e.Shed5).HasColumnName("Shed_5");

                entity.Property(e => e.Shed6).HasColumnName("Shed_6");

                entity.Property(e => e.Shed7).HasColumnName("Shed_7");

                entity.Property(e => e.Shed8).HasColumnName("Shed_8");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<TodayPlantTotalEnergy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TodayPlant_Total_Energy");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.TptEnergy).HasColumnName("TPT_Energy");
            });

            modelBuilder.Entity<TodaysDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Todays_Data");

                entity.Property(e => e.AcMaxPower).HasColumnName("AC_Max_Power");

                entity.Property(e => e.DcMaxPower).HasColumnName("DC_Max_Power");

                entity.Property(e => e.Pr).HasColumnName("PR");

                entity.Property(e => e.SpecificEnergy).HasColumnName("Specific_Energy");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<TodaysGeneration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Todays_Generation");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.TodaysGeneration1).HasColumnName("Todays_Generation");
            });

            modelBuilder.Entity<TotalAcPower>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Total_Ac_Power");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.TotalAcPower1).HasColumnName("Total_Ac_Power");
            });

            modelBuilder.Entity<TotalDcPower>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Total_Dc_Power");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.TotalDcPower1).HasColumnName("Total_Dc_Power");
            });

            modelBuilder.Entity<TotalGeneration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Total_Generation");

                entity.Property(e => e.Shed1).HasColumnName("Shed_1");

                entity.Property(e => e.Shed10).HasColumnName("Shed_10");

                entity.Property(e => e.Shed11).HasColumnName("Shed_11");

                entity.Property(e => e.Shed12).HasColumnName("Shed_12");

                entity.Property(e => e.Shed2).HasColumnName("Shed_2");

                entity.Property(e => e.Shed3And4).HasColumnName("Shed_3_and_4");

                entity.Property(e => e.Shed5).HasColumnName("Shed_5");

                entity.Property(e => e.Shed6).HasColumnName("Shed_6");

                entity.Property(e => e.Shed7).HasColumnName("Shed_7");

                entity.Property(e => e.Shed8).HasColumnName("Shed_8");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<TotalGenerationForAllInverrter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TotalGeneration_ForAll_Inverrters");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.TotalGenerationForAllInverrters).HasColumnName("TotalGeneration_ForAll_Inverrters");
            });

            modelBuilder.Entity<TotalMaxAcPower>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Total_Max_AC_Power");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.TotalMaxAcPower1).HasColumnName("Total_Max_AC_Power");
            });

            modelBuilder.Entity<TotalMaxDcPower>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Total_Max_DC_Power");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.TotalMaxDcPower1).HasColumnName("Total_Max_DC_Power");
            });

            modelBuilder.Entity<TotalPr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Total_PR");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.TotalPr1).HasColumnName("Total_PR");
            });

            modelBuilder.Entity<YesterdayPlantTotalEnergy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YesterdayPlant_TotalEnergy");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.YptEnergy).HasColumnName("YPT_Energy");
            });

            modelBuilder.Entity<YesterdaysDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Yesterdays_Data");

                entity.Property(e => e.AcMaxPower).HasColumnName("AC_Max_Power");

                entity.Property(e => e.DcMaxPower).HasColumnName("DC_Max_Power");

                entity.Property(e => e.Pr).HasColumnName("PR");

                entity.Property(e => e.SpecificEnergy).HasColumnName("Specific_Energy");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<YesterdaysGeneration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Yesterdays_Generation");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.YesterdaysGeneration1).HasColumnName("Yesterdays_Generation");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
