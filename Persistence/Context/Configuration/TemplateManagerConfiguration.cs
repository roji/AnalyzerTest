using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Context.Configuration
{
   public class TemplateManagerConfiguration : IEntityTypeConfiguration<TemplateManager>
   {
      public void Configure(EntityTypeBuilder<TemplateManager> builder)
      {
         builder.Property(e => e.Title).HasMaxLength(450).IsRequired();
         builder.Property(e => e.ContentTitle).HasMaxLength(450);
         builder.HasData(new
            {
               Id = 1,
                  Title = "تایید مجوز نقل و انتقال پسماند",
                  TemplateType = TemplateTypes.ApproveWasteTransferLicense
            },
            new
            {
               Id = 2,
                  Title = "لغو مجوز نقل و انتقال پسماند",
                  TemplateType = TemplateTypes.DenyWasteTransferLicense
            },
            new
            {
               Id = 3,
                  Title = "ایمیل خوش آمدگویی",
                  TemplateType = TemplateTypes.WelcomeEmail
            },
            new
            {
               Id = 4,
                  Title = "ایمیل تایید حساب کاربری",
                  TemplateType = TemplateTypes.ActivationEmail
            },
            new
            {
               Id = 5,
                  Title = "پیام خوش آمدید میز کار",
                  TemplateType = TemplateTypes.SystemWelcome
            },
            new
            {
               Id = 6,
                  Title = "اعلام آلایندگی مرکز",
                  TemplateType = TemplateTypes.IndustryPollution
            },
            new
            {
               Id = 7,
                  Title = "صدور اخطاریه مرکز",
                  TemplateType = TemplateTypes.IndustryWarning
            },
            new
            {
               Id = 8,
                  Title = "فعالسازی حساب کاربری",
                  TemplateType = TemplateTypes.UserActivation
            },
            new
            {
               Id = 10,
                  Title = "استفاده از کلید API",
                  TemplateType = TemplateTypes.ApiKeyUsage
            });
      }
   }
}
