using System.Collections.Generic;
using gov_connect.Data.Models;

namespace gov_connect.Data.Services
{
    public static class DocumentData
    {
        public static List<string> Categories { get; } = new()
        {
            "All Categories",
            "Civil Registry",
            "Government IDs",
            "Clearances & Certificates",
            "Business & Employment",
            "Travel & Immigration"
        };

        public static List<DocumentItem> Documents { get; } = new()
        {
            // 1. Civil Registry
            new DocumentItem { Title = "Birth Certificate", Slug = "birth-certificate", Agency = "PSA", Category = "Civil Registry", Price = "155.00", ProcessingTime = "3-5 days", IconType = "star", Description = "Official proof of live birth registry issued by PSA." },
            new DocumentItem { Title = "Marriage Certificate", Slug = "marriage-certificate", Agency = "PSA", Category = "Civil Registry", Price = "155.00", ProcessingTime = "3-5 days", IconType = "rings", Description = "Certified contract of marriage copy registered at PSA." },
            new DocumentItem { Title = "Death Certificate", Slug = "death-certificate", Agency = "PSA", Category = "Civil Registry", Price = "155.00", ProcessingTime = "3-5 days", IconType = "scroll", Description = "Official record of passing registered with PSA." },
            new DocumentItem { Title = "CENOMAR", Slug = "cenomar", Agency = "PSA", Category = "Civil Registry", Price = "210.00", ProcessingTime = "3-5 days", IconType = "rings", Description = "Certificate of No Marriage Record proving singlehood status." },

            // 2. IDs
            new DocumentItem { Title = "Philippine Passport", Slug = "philippine-passport", Agency = "DFA", Category = "Government IDs", Price = "950.00", ProcessingTime = "12 days", IconType = "airplane", Description = "Primary document for international travel and global identification." },
            new DocumentItem { Title = "National ID (PhilID)", Slug = "national-id", Agency = "PhilSys", Category = "Government IDs", Price = "Free", ProcessingTime = "10-15 days", IconType = "id", Description = "The unified official national identification card of the Philippines." },
            new DocumentItem { Title = "Driver's License", Slug = "drivers-license", Agency = "LTO", Category = "Government IDs", Price = "585.00", ProcessingTime = "1 day", IconType = "id", Description = "LTO permit authorizing operate of motor vehicles." },
            new DocumentItem { Title = "Professional ID (PRC License)", Slug = "prc-license", Agency = "PRC", Category = "Government IDs", Price = "600.00", ProcessingTime = "3-5 days", IconType = "id", Description = "Authorized license for certified local professionals." },
            new DocumentItem { Title = "UMID Card", Slug = "umid-card", Agency = "SSS / GSIS", Category = "Government IDs", Price = "Free", ProcessingTime = "30 days", IconType = "id", Description = "Unified social security and state insurance multi-purpose ID." },
            new DocumentItem { Title = "Postal ID", Slug = "postal-id", Agency = "PhlPost", Category = "Government IDs", Price = "504.00", ProcessingTime = "5-7 days", IconType = "id", Description = "Easily accessible secondary proof of identity and address." },

            // 3. Clearances & Certificates
            new DocumentItem { Title = "NBI Clearance", Slug = "nbi-clearance", Agency = "NBI", Category = "Clearances & Certificates", Price = "130.00", ProcessingTime = "1-3 days", IconType = "shield", Description = "Nationwide certification that you have zero pending criminal records." },
            new DocumentItem { Title = "Police Clearance", Slug = "police-clearance", Agency = "PNP", Category = "Clearances & Certificates", Price = "150.00", ProcessingTime = "1 day", IconType = "shield", Description = "Local police station confirmation of good legal standing." },
            new DocumentItem { Title = "Barangay Clearance", Slug = "barangay-clearance", Agency = "LGU", Category = "Clearances & Certificates", Price = "50.00", ProcessingTime = "1 day", IconType = "shield", Description = "Good moral residency check from your neighborhood hall." },
            new DocumentItem { Title = "BIR Tax Clearance", Slug = "bir-tax-clearance", Agency = "BIR", Category = "Clearances & Certificates", Price = "Free", ProcessingTime = "3-5 days", IconType = "scroll", Description = "BIR verification validating full compliance of tax dues." },

            // 4. Business & Employment
            new DocumentItem { Title = "DTI Business Registration", Slug = "dti-registration", Agency = "DTI", Category = "Business & Employment", Price = "230.00", ProcessingTime = "1 day", IconType = "briefcase", Description = "Registers a business trade name for sole proprietors." },
            new DocumentItem { Title = "SEC Registration", Slug = "sec-registration", Agency = "SEC", Category = "Business & Employment", Price = "2,000.00", ProcessingTime = "5-7 days", IconType = "briefcase", Description = "Incorporation certification for partnerships and corporations." },
            new DocumentItem { Title = "Mayor's / Business Permit", Slug = "mayors-permit", Agency = "LGU", Category = "Business & Employment", Price = "Varies", ProcessingTime = "7-14 days", IconType = "briefcase", Description = "City hall approval required to legally operate locally." },
            new DocumentItem { Title = "Barangay Business Clearance", Slug = "barangay-business-clearance", Agency = "LGU", Category = "Business & Employment", Price = "500.00", ProcessingTime = "1 day", IconType = "briefcase", Description = "Initial neighborhood clearance requisite to securing Mayor's permits." },
            new DocumentItem { Title = "Sanitary & Fire Permit", Slug = "sanitary-fire-permit", Agency = "LGU", Category = "Business & Employment", Price = "Varies", ProcessingTime = "3-5 days", IconType = "shield", Description = "Safety health compliance checklist validations." },
            new DocumentItem { Title = "TIN Verification / Card", Slug = "tin-verification", Agency = "BIR", Category = "Business & Employment", Price = "Free", ProcessingTime = "1 day", IconType = "id", Description = "Taxpayer Identification Number identification documentation." },
            new DocumentItem { Title = "SSS MDR", Slug = "sss-mdr", Agency = "SSS", Category = "Business & Employment", Price = "Free", ProcessingTime = "1 day", IconType = "scroll", Description = "Active social security system membership data records." },
            new DocumentItem { Title = "PhilHealth MDR", Slug = "philhealth-mdr", Agency = "PhilHealth", Category = "Business & Employment", Price = "Free", ProcessingTime = "1 day", IconType = "scroll", Description = "Active membership registry records with state healthcare." },
            new DocumentItem { Title = "Pag-IBIG MDF", Slug = "pagibig-mdf", Agency = "Pag-IBIG", Category = "Business & Employment", Price = "Free", ProcessingTime = "1 day", IconType = "scroll", Description = "Active member's saving fund contribution confirmation forms." },

            // 5. Travel & Immigration
            new DocumentItem { Title = "CFO Certificate", Slug = "cfo-certificate", Agency = "CFO", Category = "Travel & Immigration", Price = "Free", ProcessingTime = "1-2 days", IconType = "airplane", Description = "Required seminar clearances for spouses migrating out." },
            new DocumentItem { Title = "Travel Clearance for Minors", Slug = "travel-clearance-minors", Agency = "DSWD", Category = "Travel & Immigration", Price = "300.00", ProcessingTime = "3 days", IconType = "airplane", Description = "Guarantees secure travel permissions for unaccompanied children." },
            new DocumentItem { Title = "Emigration Clearance (ECC)", Slug = "emigration-clearance-ecc", Agency = "BI", Category = "Travel & Immigration", Price = "1,210.00", ProcessingTime = "3 days", IconType = "airplane", Description = "Exit checklist verifying foreign nationals have no active liabilities." }
        };
    }
}