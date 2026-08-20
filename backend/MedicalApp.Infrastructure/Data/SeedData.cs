using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp.Infrastructure.Data
{
    public static class SeedData
    {
        public static readonly DateTime CreatedAt =
            new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static readonly Guid GeneralMedicineId =
            Guid.Parse("11111111-1111-1111-1111-111111111111");

        public static readonly Guid CardiologyId =
            Guid.Parse("22222222-2222-2222-2222-222222222222");

        public static readonly Guid DermatologyId =
            Guid.Parse("33333333-3333-3333-3333-333333333333");

        public static readonly Guid PediatricsId =
            Guid.Parse("44444444-4444-4444-4444-444444444444");

        public static readonly Guid NeurologyId =
            Guid.Parse("55555555-5555-5555-5555-555555555555");

        public static readonly Guid CarlosId =
            Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa");

        public static readonly Guid MariaId =
            Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb");

        public static readonly Guid AlejandroId =
            Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc");

        public static readonly Guid LauraId =
            Guid.Parse("dddddddd-dddd-dddd-dddd-dddddddddddd");
    }
}
