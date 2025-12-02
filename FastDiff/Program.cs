//Uncomment section and set breakpoin on variable 'a' and see the time of complie and result

#region simple Object


//var oldModel= new Product
//{
//    ProductTypeId = 1,                          // Simple product
//    ParentGroupedProductId = 0,
//    VisibleIndividually = true,
//    Name = "لپ‌تاپ گیمینگ ASUS ROG Strix G17",
//    ShortDescription = "لپ‌تاپ قدرتمند گیمینگ با کارت گرافیک RTX 4070",
//    FullDescription = @"
//        <p>لپ‌تاپ ASUS ROG Strix G17 با پردازنده Ryzen 9 7945HX، کارت گرافیک NVIDIA RTX 4070 8GB، 
//        32 گیگابایت رم DDR5 و 1 ترابایت SSD NVMe. صفحه‌نمایش 17.3 اینچ QHD با نرخ نوسازی 240 هرتز 
//        و فناوری G-Sync برای بهترین تجربه گیمینگ.</p>
//        <ul>
//            <li>پردازنده: AMD Ryzen 9 7945HX</li>
//            <li>گرافیک: NVIDIA GeForce RTX 4070 8GB</li>
//            <li>رم: 32GB DDR5 4800MHz</li>
//            <li>حافظه: 1TB SSD PCIe 4.0</li>
//            <li>صفحه‌نمایش: 17.3"" QHD 240Hz</li>
//        </ul>",
//    AdminComment = "محصول پرطرفدار - موجود در انبار اصلی",
//    ProductTemplateId = 1,
//    VendorId = 7,                               // مثلاً برند ASUS
//    ShowOnHomepage = true,
//    MetaKeywords = "لپ تاپ گیمینگ, ASUS ROG, RTX 4070, رایزن 9",
//    MetaTitle = "خرید لپ‌تاپ گیمینگ ASUS ROG Strix G17 - رایزن 9 + RTX 4070",
//    MetaDescription = "لپ‌تاپ گیمینگ  ROG Strix G17 با پردازنده Ryzen 9 و گرافیک RTX 4070، مناسب گیمرهای حرفه‌ای و تولید محتوا",

//    AllowCustomerReviews = true,
//    ApprovedRatingSum = 87,
//    ApprovedTotalReviews = 22,
//    SubjectToAcl = false,
//    LimitedToStores = true,

//    Sku = "ASUS-ROG-G17-2025",
//    ManufacturerPartNumber = "G713PI-LL064",
//    Gtin = "4711081776543",

//    IsGiftCard = false,
//    IsDownload = false,
//    IsRecurring = false,
//    IsRental = false,

//    IsShipEnabled = true,
//    IsFreeShipping = false,
//    ShipSeparately = false,
//    AdditionalShippingCharge = 0,
//    Weight = 2.9m,           // کیلوگرم
//    Length = 39.9m,          // سانتی‌متر
//    Width = 28.2m,
//    Height = 5m,

//    IsTaxExempt = false,
//    TaxCategoryId = 1,       // استاندارد

//    ManageInventoryMethodId = 1, // Track inventory
//    StockQuantity = 12,
//    DisplayStockAvailability = true,
//    DisplayStockQuantity = true,
//    MinStockQuantity = 2,
//    LowStockActivityId = 1,  // ایمیل بده وقتی کم شد
//    NotifyAdminForQuantityBelow = 5,
//    OrderMinimumQuantity = 1,
//    OrderMaximumQuantity = 10,

//    DisableBuyButton = false,
//    DisableWishlistButton = false,
//    AvailableForPreOrder = false,
//    CallForPrice = false,

//    Price = 82_900_000m,      // قیمت به تومان
//    OldPrice = 89_900_000m,    // قیمت قبلی (برای تخفیف)
//    ProductCost = 72_000_000m,

//    MarkAsNew = true,
//    MarkAsNewStartDateTimeUtc = DateTime.UtcNow.AddDays(-7),
//    MarkAsNewEndDateTimeUtc = DateTime.UtcNow.AddDays(23),

//    HasTierPrices = true,        // مثلاً خرید ۲ تا تخفیف بیشتر
//    HasDiscountsApplied = true,  // ۸٪ تخفیف فعلی

//    Published = true,
//    Deleted = false,
//    CreatedOnUtc = DateTime.UtcNow.AddMonths(-4),
//    UpdatedOnUtc = DateTime.UtcNow
//};
//var newModel = new Product
//{
//    ProductTypeId = 1,                          // Simple product
//    ParentGroupedProductId = 0,
//    VisibleIndividually = true,
//    Name = "لپ‌تاپ گیمینگ ASUS ROG Strix G17",
//    ShortDescription = "لپ‌تاپ قدرتمند گیمینگ با کارت گرافیک RTX 4070",
//    FullDescription = @"
//        <p>لپ‌تاپ ASUS ROG Strix G17 با پردازنده Ryzen 9 7945HX، کارت گرافیک NVIDIA RTX 4070 8GB، 
//        32 گیگابایت رم DDR5 و 1 ترابایت SSD NVMe. صفحه‌نمایش 17.3 اینچ QHD با نرخ نوسازی 240 هرتز 
//        و فناوری G-Sync برای بهترین تجربه گیمینگ.</p>
//        <ul>
//            <li>پردازنده: AMD Ryzen 9 7945HX</li>
//            <li>گرافیک: NVIDIA GeForce RTX 4070 8GB</li>
//            <li>رم: 32GB DDR5 4800MHz</li>
//            <li>حافظه: 1TB SSD PCIe 4.0</li>
//            <li>صفحه‌نمایش: 17.3"" QHD 240Hz</li>
//        </ul>",
//    AdminComment = "محصول پرطرفدار - موجود در انبار اصلی",
//    ProductTemplateId = 1,
//    VendorId = 7,                               // مثلاً برند ASUS
//    ShowOnHomepage = true,
//    MetaKeywords = "لپ تاپ گیمینگ, ASUS ROG, RTX 4070, رایزن 9",
//    MetaTitle = "خرید لپ‌تاپ گیمینگ ASUS ROG Strix G17 - رایزن 9 + RTX 4070",
//    MetaDescription = "لپ‌تاپ گیمینگ  ROG Strix G17 با پردازنده Ryzen 9 و گرافیک RTX 4070، مناسب گیمرهای حرفه‌ای و تولید محتوا",

//    AllowCustomerReviews = true,
//    ApprovedRatingSum = 87,
//    ApprovedTotalReviews = 22,
//    SubjectToAcl = false,
//    LimitedToStores = true,

//    Sku = "ASUS-ROG-G17-2025",
//    ManufacturerPartNumber = "G713PI-LL064",
//    Gtin = "4711081776543",

//    IsGiftCard = false,
//    IsDownload = false,
//    IsRecurring = false,
//    IsRental = false,

//    IsShipEnabled = true,
//    IsFreeShipping = false,
//    ShipSeparately = false,
//    AdditionalShippingCharge = 0,
//    Weight = 2.9m,           // کیلوگرم
//    Length = 39.9m,          // سانتی‌متر
//    Width = 28.2m,
//    Height = 5m,

//    IsTaxExempt = false,
//    TaxCategoryId = 1,       // استاندارد

//    ManageInventoryMethodId = 1, // Track inventory
//    StockQuantity = 12,
//    DisplayStockAvailability = true,
//    DisplayStockQuantity = true,
//    MinStockQuantity = 2,
//    LowStockActivityId = 1,  // ایمیل بده وقتی کم شد
//    NotifyAdminForQuantityBelow = 5,
//    OrderMinimumQuantity = 1,
//    OrderMaximumQuantity = 10,

//    DisableBuyButton = false,
//    DisableWishlistButton = false,
//    AvailableForPreOrder = false,
//    CallForPrice = false,

//    Price = 82_900_000m,      // قیمت به تومان
//    OldPrice = 89_900_000m,    // قیمت قبلی (برای تخفیف)
//    ProductCost = 72_000_000m,

//    MarkAsNew = true,
//    MarkAsNewStartDateTimeUtc = DateTime.UtcNow.AddDays(-7),
//    MarkAsNewEndDateTimeUtc = DateTime.UtcNow.AddDays(23),

//    HasTierPrices = true,        // مثلاً خرید ۲ تا تخفیف بیشتر
//    HasDiscountsApplied = true,  // ۸٪ تخفیف فعلی

//    Published = true,
//    Deleted = false,
//    CreatedOnUtc = DateTime.UtcNow.AddMonths(-4),
//    UpdatedOnUtc = DateTime.UtcNow
//};
//var res = FastDiff.SmartDiffer<Product>.GetDiffJson(oldModel, newModel);



//var oldModel2 = new Product
//{
//    ProductTypeId = 1,                          // Simple product
//    ParentGroupedProductId = 0,
//    VisibleIndividually = true,
//    Name = "لپ‌تاپ گیمینگ ASUS ROG Strix G17",
//    ShortDescription = "لپ‌تاپ قدرتمند گیمینگ با کارت گرافیک RTX 4070",
//    FullDescription = @"
//        <p>لپ‌تاپ ASUS ROG Strix G17 با پردازنده Ryzen 9 7945HX، کارت گرافیک NVIDIA RTX 4070 8GB، 
//        32 گیگابایت رم DDR5 و 1 ترابایت SSD NVMe. صفحه‌نمایش 17.3 اینچ QHD با نرخ نوسازی 240 هرتز 
//        و فناوری G-Sync برای بهترین تجربه گیمینگ.</p>
//        <ul>
//            <li>پردازنده: AMD Ryzen 9 7945HX</li>
//            <li>گرافیک: NVIDIA GeForce RTX 4070 8GB</li>
//            <li>رم: 32GB DDR5 4800MHz</li>
//            <li>حافظه: 1TB SSD PCIe 4.0</li>
//            <li>صفحه‌نمایش: 17.3"" QHD 240Hz</li>
//        </ul>",
//    AdminComment = "محصول پرطرفدار - موجود در انبار اصلی",
//    ProductTemplateId = 1,
//    VendorId = 7,                               // مثلاً برند ASUS
//    ShowOnHomepage = true,
//    MetaKeywords = "لپ تاپ گیمینگ, ASUS ROG, RTX 4070, رایزن 9",
//    MetaTitle = "خرید لپ‌تاپ گیمینگ ASUS ROG Strix G17 - رایزن 9 + RTX 4070",
//    MetaDescription = "لپ‌تاپ گیمینگ  ROG Strix G17 با پردازنده Ryzen 9 و گرافیک RTX 4070، مناسب گیمرهای حرفه‌ای و تولید محتوا",

//    AllowCustomerReviews = true,
//    ApprovedRatingSum = 87,
//    ApprovedTotalReviews = 22,
//    SubjectToAcl = false,
//    LimitedToStores = true,

//    Sku = "ASUS-ROG-G17-2025",
//    ManufacturerPartNumber = "G713PI-LL064",
//    Gtin = "4711081776543",

//    IsGiftCard = false,
//    IsDownload = false,
//    IsRecurring = false,
//    IsRental = false,

//    IsShipEnabled = true,
//    IsFreeShipping = false,
//    ShipSeparately = false,
//    AdditionalShippingCharge = 0,
//    Weight = 2.9m,           // کیلوگرم
//    Length = 39.9m,          // سانتی‌متر
//    Width = 28.2m,
//    Height = 5m,

//    IsTaxExempt = false,
//    TaxCategoryId = 1,       // استاندارد

//    ManageInventoryMethodId = 1, // Track inventory
//    StockQuantity = 12,
//    DisplayStockAvailability = true,
//    DisplayStockQuantity = true,
//    MinStockQuantity = 2,
//    LowStockActivityId = 1,  // ایمیل بده وقتی کم شد
//    NotifyAdminForQuantityBelow = 5,
//    OrderMinimumQuantity = 1,
//    OrderMaximumQuantity = 10,

//    DisableBuyButton = false,
//    DisableWishlistButton = false,
//    AvailableForPreOrder = false,
//    CallForPrice = false,

//    Price = 82_900_000m,      // قیمت به تومان
//    OldPrice = 89_900_000m,    // قیمت قبلی (برای تخفیف)
//    ProductCost = 72_000_000m,

//    MarkAsNew = true,
//    MarkAsNewStartDateTimeUtc = DateTime.UtcNow.AddDays(-7),
//    MarkAsNewEndDateTimeUtc = DateTime.UtcNow.AddDays(23),

//    HasTierPrices = true,        // مثلاً خرید ۲ تا تخفیف بیشتر
//    HasDiscountsApplied = true,  // ۸٪ تخفیف فعلی

//    Published = true,
//    Deleted = false,
//    CreatedOnUtc = DateTime.UtcNow.AddMonths(-4),
//    UpdatedOnUtc = DateTime.UtcNow
//};
//var book = new Product
//{
//    ProductTypeId = 1,                                   // Simple product
//    ParentGroupedProductId = 0,
//    VisibleIndividually = true,

//    Name = "کیمیاگر",
//    ShortDescription = "رمانی الهام‌بخش از پائولو کوئیلو – پرفروش‌ترین کتاب ترجمه‌شده جهان",
//    FullDescription = """
//        <p><strong>کیمیاگر</strong> نوشتهٔ پائولو کوئیلو، داستان چوپانی اسپانیایی به نام سانتیاگو است 
//        که رویای یافتن گنجی در نزدیکی اهرام مصر را می‌بیند و برای دنبال کردن «افسانهٔ شخصی» خود 
//        تمام زندگی‌اش را رها می‌کند.</p>
//        <p>این کتاب در بیش از ۱۷۰ کشور منتشر شده و به ۸۳ زبان ترجمه شده است. 
//        رکورد گینس «پرفروش‌ترین کتاب نوشته‌شده توسط یک نویسنده زنده» را دارد.</p>
//        <ul>
//            <li>نویسنده: پائولو کوئیلو</li>
//            <li>مترجم: آرش حجازی</li>
//            <li>ناشر: نشر کاروان</li>
//            <li>سال چاپ: ۱۴۰۳ (چاپ نود و پنجم)</li>
//            <li>تعداد صفحات: ۲۰۸</li>
//            <li>شابک: 978-964-7033-38-1</li>
//        </ul>
//        """,

//    AdminComment = "همیشه پرفروش – موجودی دائمی – چاپ جدید رسید",

//    ProductTemplateId = 1,
//    VendorId = 12,                                       // نشر کاروان
//    ShowOnHomepage = true,
//    MetaKeywords = "کیمیاگر, پائولو کوئیلو, کتاب انگیزشی, افسانه شخصی, رمان فلسفی",
//    MetaTitle = "خرید کتاب کیمیاگر پائولو کوئیلو - چاپ ۱۴۰۳ نشر کاروان با بهترین قیمت",
//    MetaDescription = "کیمیاگر پائولو کوئیلو – کتابی که زندگی میلیون‌ها نفر را تغییر داد. چاپ جدید ۱۴۰۳ با جلد شومیز",

//    AllowCustomerReviews = true,
//    ApprovedRatingSum = 412,
//    ApprovedTotalReviews = 98,

//    SubjectToAcl = false,
//    LimitedToStores = false,

//    Sku = "BOOK-KIMIAGAR-1403",
//    ManufacturerPartNumber = "9789647033381",
//    Gtin = "9789647033381",

//    IsGiftCard = false,
//    IsDownload = false,
//    IsRecurring = false,
//    IsRental = false,

//    IsShipEnabled = true,
//    IsFreeShipping = true,                               // بالای ۵۰۰ تومن ارسال رایگان
//    ShipSeparately = false,
//    AdditionalShippingCharge = 0,
//    Weight = 0.32m,                                      // ۳۲۰ گرم
//    Length = 21.0m,
//    Width = 14.0m,
//    Height = 1.8m,

//    IsTaxExempt = false,
//    TaxCategoryId = 3,                                   // کتاب معاف از مالیات نیست ولی نرخ پایین داره

//    ManageInventoryMethodId = 1,
//    StockQuantity = 87,
//    DisplayStockAvailability = true,
//    DisplayStockQuantity = false,
//    MinStockQuantity = 10,
//    LowStockActivityId = 2,
//    NotifyAdminForQuantityBelow = 20,
//    OrderMinimumQuantity = 1,
//    OrderMaximumQuantity = 50,

//    DisableBuyButton = false,
//    DisableWishlistButton = false,
//    AvailableForPreOrder = false,
//    CallForPrice = false,

//    Price = 248_000m,
//    OldPrice = 285_000m,                                 // ۱۳٪ تخفیف دائمی
//    ProductCost = 135_000m,

//    MarkAsNew = false,
//    HasTierPrices = true,                                // خرید ۳ جلد → ۲۲٪ تخفیف
//    HasDiscountsApplied = true,

//    Published = true,
//    Deleted = false,

//    CreatedOnUtc = new DateTime(2018, 5, 10, 0, 0, 0, DateTimeKind.Utc),
//    UpdatedOnUtc = DateTime.UtcNow
//}; var 
//    res2 = FastDiff.SmartDiffer<Product>.GetDiffJson(oldModel2, book);

#endregion


#region Nested Object

var snapshot = new ElearningPlatformAnalyticsSnapshot
{
    Info = new SnapshotInfo
    {
        SnapshotId = Guid.NewGuid(),
        CapturedAtUtc = DateTime.UtcNow,
        CapturedBy = "AnalyticsBot-v3.0",
        Environment = "Production"
    },

    Overview = new PlatformOverview
    {
        TotalStudents = 150_000,
        ActiveToday = 25_000,
        TotalCourses = 1_200,
        TotalRevenueThisMonth = 3_500_000_000m,
        Engagement = new EngagementMetrics
        {
            AvgSessionDurationMinutes = 45.5,
            AvgCompletionRate = 0.72,
            DailyActive = new TimeSeries<DailyActiveUsers>
            {
                DataPoints = new List<DailyActiveUsers>
                {
                    new DailyActiveUsers { Date = DateTime.UtcNow.AddDays(-7), Count = 20_000 },
                    new DailyActiveUsers { Date = DateTime.UtcNow.AddDays(-1), Count = 24_500 }
                }
            }
        }
    },

    Universities = new List<UniversityAnalytics>
    {
        new UniversityAnalytics
        {
            UniversityId = 1,
            Name = "دانشگاه تهران",
            Domain = "lms.ut.ac.ir",
            Plan = UniversityPlan.Enterprise,
            Departments = new List<DepartmentAnalytics>
            {
                new DepartmentAnalytics
                {
                    DepartmentId = 101,
                    Name = "علوم کامپیوتر",
                    CourseInstances = new List<CourseInstanceAnalytics>
                    {
                        new CourseInstanceAnalytics
                        {
                            InstanceId = 5001,
                            Semester = "1404-1",
                            StartDate = new DateTime(2025, 9, 1),
                            EndDate = new DateTime(2026, 1, 15),
                            Template = new CourseTemplate
                            {
                                TemplateId = 301,
                                Title = "یادگیری ماشین پیشرفته",
                                Code = "CS-ML-702",
                                CreditHours = 4,
                                Difficulty = DifficultyLevel.Advanced,
                                Curriculum = new Curriculum
                                {
                                    Modules = new List<Module>
                                    {
                                        new Module
                                        {
                                            ModuleId = 1001,
                                            Title = "مقدمه بر شبکه‌های عصبی",
                                            Order = 1,
                                            Contents = new List<ContentItem>
                                            {
                                                new ContentItem
                                                {
                                                    ItemId = Guid.NewGuid(),
                                                    Title = "ویدیو مقدماتی",
                                                    Type = ContentType.Video,
                                                    Video = new VideoContent
                                                    {
                                                        Url = "https://cdn.example.com/videos/neural-intro.mp4",
                                                        DurationSeconds = 3600,
                                                        Transcript = new Transcript
                                                        {
                                                            Language = "fa",
                                                            Lines = new List<TranscriptLine>
                                                            {
                                                                new TranscriptLine { StartSecond = 0f, EndSecond = 10f, Text = "سلام، در این درس به شبکه‌های عصبی می‌پردازیم." },
                                                                new TranscriptLine { StartSecond = 10f, EndSecond = 20f, Text = "شبکه‌های عصبی الهام‌گرفته از مغز انسان هستند." }
                                                            }
                                                        }
                                                    }
                                                },
                                                new ContentItem
                                                {
                                                    ItemId = Guid.NewGuid(),
                                                    Title = "اسلایدهای درس",
                                                    Type = ContentType.PDF,
                                                    Pdf = new PdfContent
                                                    {
                                                        Url = "https://cdn.example.com/pdfs/neural-slides.pdf",
                                                        PageCount = 45
                                                    }
                                                }
                                            },
                                            FinalQuiz = new Quiz
                                            {
                                                QuizId = 2001,
                                                Title = "کوئیز مقدماتی",
                                                Questions = new List<Question>
                                                {
                                                    new Question { QuestionId = 1, Text = "شبکه عصبی چیست؟" },
                                                    new Question { QuestionId = 2, Text = "تفاوت MLP و CNN چیست؟" }
                                                }
                                            }
                                        }
                                    },
                                    Outcomes = new List<LearningOutcome>
                                    {
                                        new LearningOutcome { Description = "درک مفاهیم پایه یادگیری ماشین" },
                                        new LearningOutcome { Description = "پیاده‌سازی مدل‌های ساده" }
                                    }
                                }
                            },
                            Instructor = new InstructorAnalytics
                            {
                                InstructorId = 401,
                                Name = "دکتر علی رضایی",
                                AvgRating = 4.8m,
                                TotalStudentsTaught = 350
                            },
                            EnrolledStudents = new List<StudentProgress>
                            {
                                new StudentProgress
                                {
                                    StudentId = 10001,
                                    FullName = "سارا احمدی",
                                    EnrolledAt = new DateTime(2025, 8, 20),
                                    ProgressPercentage = 85.5,
                                    LastActivityAt = DateTime.UtcNow.AddDays(-2),
                                    FinalGrade = new Grade { Value = 18.5m, Letter = "A" },
                                    ModuleProgresses = new Dictionary<int, ModuleProgress>
                                    {
                                        { 1001, new ModuleProgress
                                            {
                                                IsCompleted = true,
                                                CompletedAt = DateTime.UtcNow.AddDays(-5),
                                                TimeSpentSeconds = 7200,
                                                QuizAttempts = new List<QuizAttempt>
                                                {
                                                    new QuizAttempt { AttemptedAt = DateTime.UtcNow.AddDays(-6), Score = 85, OutOf = 100 },
                                                    new QuizAttempt { AttemptedAt = DateTime.UtcNow.AddDays(-5), Score = 95, OutOf = 100 }
                                                }
                                            }
                                        }
                                    }
                                }
                            },
                            Forum = new ForumAnalytics
                            {
                                TotalPosts = 120,
                                ActiveThreads = 15,
                                ResolvedQuestions = 80
                            }
                        }
                    },
                    BestInstructor = new InstructorPerformance
                    {
                        InstructorId = 401,
                        Name = "دکتر علی رضایی",
                        AvgRating = 4.8m,
                        CoursesTaught = 12
                    }
                }
            },
            TopStudents = new List<TopStudent>
            {
                new TopStudent
                {
                    StudentId = 10001,
                    Name = "سارا احمدی",
                    TotalPoints = 1500,
                    CompletedCourses = 8,
                    Badges = new BadgeCollection
                    {
                        EarnedBadges = new List<string> { "یادگیرنده برتر", "کوئیز مستر" },
                        BadgeEarnedAt = new Dictionary<string, DateTime>
                        {
                            { "یادگیرنده برتر", DateTime.UtcNow.AddMonths(-1) }
                        }
                    }
                }
            }
        }
    },

    Leaderboard = new GlobalLeaderboard
    {
        MonthlyTop = new List<TopStudent>
        {
            new TopStudent
            {
                StudentId = 10001,
                Name = "سارا احمدی",
                TotalPoints = 1500,
                CompletedCourses = 8,
                Badges = new BadgeCollection
                {
                    EarnedBadges = new List<string> { "یادگیرنده برتر" },
                    BadgeEarnedAt = new Dictionary<string, DateTime>
                    {
                        { "یادگیرنده برتر", DateTime.UtcNow.AddMonths(-1) }
                    }
                }
            }
        },
        TopInstructors = new List<TopInstructor>
        {
            new TopInstructor
            {
                InstructorId = 401,
                Name = "دکتر علی رضایی",
                AvgRating = 4.8m,
                TotalStudents = 350
            }
        }
    },

    Health = new SystemHealth
    {
        Database = new ServerStatus { IsHealthy = true, ResponseTimeMs = 12.5, LastChecked = DateTime.UtcNow.ToString() },
        Cache = new ServerStatus { IsHealthy = true, ResponseTimeMs = 5.2, LastChecked = DateTime.UtcNow.ToString() },
        VideoCdn = new ServerStatus { IsHealthy = false, ResponseTimeMs = 150.0, LastChecked = DateTime.UtcNow.ToString() },
        RecentErrors = new List<RecentError>
        {
            new RecentError
            {
                OccurredAt = DateTime.UtcNow.AddHours(-3),
                Message = "اتصال به CDN قطع شد",
                StackTrace = "در متد UploadVideo خطا رخ داد",
                Severity = "Critical"
            }
        }
    },

    RawMetrics = new Dictionary<string, object>
    {
        { "cpu_usage", 45.6 },
        { "memory_gb", 12.8 },
        { "active_sessions", 25000 }
    }
};
var snapshot1 = new ElearningPlatformAnalyticsSnapshot
{
    Info = new SnapshotInfo
    {
        SnapshotId = Guid.NewGuid(),
        CapturedAtUtc = DateTime.UtcNow,
        CapturedBy = "AnalyticsBot-v3.0",
        Environment = "Production"
    },

    Overview = new PlatformOverview
    {
        TotalStudents = 150_000,
        ActiveToday = 25_000,
        TotalCourses = 1_200,
        TotalRevenueThisMonth = 3_500_000_000m,
        Engagement = new EngagementMetrics
        {
            AvgSessionDurationMinutes = 45.5,
            AvgCompletionRate = 0.72,
            DailyActive = new TimeSeries<DailyActiveUsers>
            {
                DataPoints = new List<DailyActiveUsers>
                {
                    new DailyActiveUsers { Date = DateTime.UtcNow.AddDays(-7), Count = 20_000 },
                    new DailyActiveUsers { Date = DateTime.UtcNow.AddDays(-1), Count = 24_500 }
                }
            }
        }
    },

    Universities = new List<UniversityAnalytics>
    {
        new UniversityAnalytics
        {
            UniversityId = 1,
            Name = "دانشگاه تهران",
            Domain = "lms.ut.ac.ir",
            Plan = UniversityPlan.Enterprise,
            Departments = new List<DepartmentAnalytics>
            {
                new DepartmentAnalytics
                {
                    DepartmentId = 101,
                    Name = "علوم کامپیوتر",
                    CourseInstances = new List<CourseInstanceAnalytics>
                    {
                        new CourseInstanceAnalytics
                        {
                            InstanceId = 5001,
                            Semester = "1404-1",
                            StartDate = new DateTime(2025, 9, 1),
                            EndDate = new DateTime(2026, 1, 15),
                            Template = new CourseTemplate
                            {
                                TemplateId = 301,
                                Title = "یادگیری ماشین پیشرفته",
                                Code = "CS-ML-702",
                                CreditHours = 4,
                                Difficulty = DifficultyLevel.Advanced,
                                Curriculum = new Curriculum
                                {
                                    Modules = new List<Module>
                                    {
                                        new Module
                                        {
                                            ModuleId = 1001,
                                            Title = "مقدمه بر شبکه‌های عصبی",
                                            Order = 1,
                                            Contents = new List<ContentItem>
                                            {
                                                new ContentItem
                                                {
                                                    ItemId = Guid.NewGuid(),
                                                    Title = "ویدیو مقدماتی",
                                                    Type = ContentType.Video,
                                                    Video = new VideoContent
                                                    {
                                                        Url = "https://cdn.example.com/videos/neural-intro.mp4",
                                                        DurationSeconds = 3600,
                                                        Transcript = new Transcript
                                                        {
                                                            Language = "fa",
                                                            Lines = new List<TranscriptLine>
                                                            {
                                                                new TranscriptLine { StartSecond = 0f, EndSecond = 10f, Text = "سلام، در این درس به شبکه‌های عصبی می‌پردازیم." },
                                                                new TranscriptLine { StartSecond = 10f, EndSecond = 20f, Text = "شبکه‌های عصبی الهام‌گرفته از مغز انسان هستند." }
                                                            }
                                                        }
                                                    }
                                                },
                                                new ContentItem
                                                {
                                                    ItemId = Guid.NewGuid(),
                                                    Title = "اسلایدهای درس",
                                                    Type = ContentType.PDF,
                                                    Pdf = new PdfContent
                                                    {
                                                        Url = "https://cdn.example.com/pdfs/neural-slides.pdf",
                                                        PageCount = 45
                                                    }
                                                }
                                            },
                                            FinalQuiz = new Quiz
                                            {
                                                QuizId = 2001,
                                                Title = "کوئیز مقدماتی",
                                                Questions = new List<Question>
                                                {
                                                    new Question { QuestionId = 1, Text = "شبکه عصبی چیست؟" },
                                                    new Question { QuestionId = 2, Text = "تفاوت MLP و CNN چیست؟" }
                                                }
                                            }
                                        }
                                    },
                                    Outcomes = new List<LearningOutcome>
                                    {
                                        new LearningOutcome { Description = "درک مفاهیم پایه یادگیری ماشین" },
                                        new LearningOutcome { Description = "پیاده‌سازی مدل‌های ساده" }
                                    }
                                }
                            },
                            Instructor = new InstructorAnalytics
                            {
                                InstructorId = 401,
                                Name = "دکتر علی رضایی",
                                AvgRating = 4.8m,
                                TotalStudentsTaught = 350
                            },
                            EnrolledStudents = new List<StudentProgress>
                            {
                                new StudentProgress
                                {
                                    StudentId = 10001,
                                    FullName = "سارا احمدی",
                                    EnrolledAt = new DateTime(2025, 8, 20),
                                    ProgressPercentage = 85.5,
                                    LastActivityAt = DateTime.UtcNow.AddDays(-2),
                                    FinalGrade = new Grade { Value = 18.5m, Letter = "A" },
                                    ModuleProgresses = new Dictionary<int, ModuleProgress>
                                    {
                                        { 1001, new ModuleProgress
                                            {
                                                IsCompleted = true,
                                                CompletedAt = DateTime.UtcNow.AddDays(-5),
                                                TimeSpentSeconds = 7200,
                                                QuizAttempts = new List<QuizAttempt>
                                                {
                                                    new QuizAttempt { AttemptedAt = DateTime.UtcNow.AddDays(-6), Score = 85, OutOf = 100 },
                                                    new QuizAttempt { AttemptedAt = DateTime.UtcNow.AddDays(-5), Score = 95, OutOf = 100 }
                                                }
                                            }
                                        }
                                    }
                                }
                            },
                            Forum = new ForumAnalytics
                            {
                                TotalPosts = 120,
                                ActiveThreads = 15,
                                ResolvedQuestions = 80
                            }
                        }
                    },
                    BestInstructor = new InstructorPerformance
                    {
                        InstructorId = 401,
                        Name = "دکتر علی رضایی",
                        AvgRating = 4.8m,
                        CoursesTaught = 12
                    }
                }
            },
            TopStudents = new List<TopStudent>
            {
                new TopStudent
                {
                    StudentId = 10001,
                    Name = "سارا احمدی",
                    TotalPoints = 1500,
                    CompletedCourses = 8,
                    Badges = new BadgeCollection
                    {
                        EarnedBadges = new List<string> { "یادگیرنده برتر", "کوئیز مستر" },
                        BadgeEarnedAt = new Dictionary<string, DateTime>
                        {
                            { "یادگیرنده برتر", DateTime.UtcNow.AddMonths(-1) }
                        }
                    }
                }
            }
        }
    },

    Leaderboard = new GlobalLeaderboard
    {
        MonthlyTop = new List<TopStudent>
        {
            new TopStudent
            {
                StudentId = 10001,
                Name = "سارا احمدی",
                TotalPoints = 1500,
                CompletedCourses = 8,
                Badges = new BadgeCollection
                {
                    EarnedBadges = new List<string> { "یادگیرنده برتر" },
                    BadgeEarnedAt = new Dictionary<string, DateTime>
                    {
                        { "یادگیرنده برتر", DateTime.UtcNow.AddMonths(-1) }
                    }
                }
            }
        },
        TopInstructors = new List<TopInstructor>
        {
            new TopInstructor
            {
                InstructorId = 401,
                Name = "دکتر علی رضایی",
                AvgRating = 4.8m,
                TotalStudents = 350
            }
        }
    },

    Health = new SystemHealth
    {
        Database = new ServerStatus { IsHealthy = true, ResponseTimeMs = 12.5, LastChecked = DateTime.UtcNow.ToString() },
        Cache = new ServerStatus { IsHealthy = true, ResponseTimeMs = 5.2, LastChecked = DateTime.UtcNow.ToString() },
        VideoCdn = new ServerStatus { IsHealthy = false, ResponseTimeMs = 150.0, LastChecked = DateTime.UtcNow.ToString() },
        RecentErrors = new List<RecentError>
        {
            new RecentError
            {
                OccurredAt = DateTime.UtcNow.AddHours(-3),
                Message = "اتصال به CDN قطع شد",
                StackTrace = "در متد UploadVideo خطا رخ داد",
                Severity = "Critical"
            }
        }
    },

    RawMetrics = new Dictionary<string, object>
    {
        { "cpu_usage", 45.6 },
        { "memory_gb", 12.8 },
        { "active_sessions", 25000 }
    }
};
var NestedRes = FastDiff.SmartDiffer<ElearningPlatformAnalyticsSnapshot>.GetDiffJson(snapshot, snapshot1);


var snapshot2 = new ElearningPlatformAnalyticsSnapshot
{
    Info = new SnapshotInfo
    {
        SnapshotId = Guid.NewGuid(),
        CapturedAtUtc = DateTime.UtcNow,
        CapturedBy = "AnalyticsBot-v3.0",
        Environment = "Production"
    },

    Overview = new PlatformOverview
    {
        TotalStudents = 150_000,
        ActiveToday = 25_000,
        TotalCourses = 1_200,
        TotalRevenueThisMonth = 3_500_000_000m,
        Engagement = new EngagementMetrics
        {
            AvgSessionDurationMinutes = 45.5,
            AvgCompletionRate = 0.72,
            DailyActive = new TimeSeries<DailyActiveUsers>
            {
                DataPoints = new List<DailyActiveUsers>
                {
                    new DailyActiveUsers { Date = DateTime.UtcNow.AddDays(-7), Count = 20_000 },
                    new DailyActiveUsers { Date = DateTime.UtcNow.AddDays(-1), Count = 24_500 }
                }
            }
        }
    },

    Universities = new List<UniversityAnalytics>
    {
        new UniversityAnalytics
        {
            UniversityId = 1,
            Name = "دانشگاه تهران",
            Domain = "lms.ut.ac.ir",
            Plan = UniversityPlan.Enterprise,
            Departments = new List<DepartmentAnalytics>
            {
                new DepartmentAnalytics
                {
                    DepartmentId = 101,
                    Name = "علوم کامپیوتر",
                    CourseInstances = new List<CourseInstanceAnalytics>
                    {
                        new CourseInstanceAnalytics
                        {
                            InstanceId = 5001,
                            Semester = "1404-1",
                            StartDate = new DateTime(2025, 9, 1),
                            EndDate = new DateTime(2026, 1, 15),
                            Template = new CourseTemplate
                            {
                                TemplateId = 301,
                                Title = "یادگیری ماشین پیشرفته",
                                Code = "CS-ML-702",
                                CreditHours = 4,
                                Difficulty = DifficultyLevel.Advanced,
                                Curriculum = new Curriculum
                                {
                                    Modules = new List<Module>
                                    {
                                        new Module
                                        {
                                            ModuleId = 1001,
                                            Title = "مقدمه بر شبکه‌های عصبی",
                                            Order = 1,
                                            Contents = new List<ContentItem>
                                            {
                                                new ContentItem
                                                {
                                                    ItemId = Guid.NewGuid(),
                                                    Title = "ویدیو مقدماتی",
                                                    Type = ContentType.Video,
                                                    Video = new VideoContent
                                                    {
                                                        Url = "https://cdn.example.com/videos/neural-intro.mp4",
                                                        DurationSeconds = 3600,
                                                        Transcript = new Transcript
                                                        {
                                                            Language = "fa",
                                                            Lines = new List<TranscriptLine>
                                                            {
                                                                new TranscriptLine { StartSecond = 0f, EndSecond = 10f, Text = "سلام، در این درس به شبکه‌های عصبی می‌پردازیم." },
                                                                new TranscriptLine { StartSecond = 10f, EndSecond = 20f, Text = "شبکه‌های عصبی الهام‌گرفته از مغز انسان هستند." }
                                                            }
                                                        }
                                                    }
                                                },
                                                new ContentItem
                                                {
                                                    ItemId = Guid.NewGuid(),
                                                    Title = "اسلایدهای درس",
                                                    Type = ContentType.PDF,
                                                    Pdf = new PdfContent
                                                    {
                                                        Url = "https://cdn.example.com/pdfs/neural-slides.pdf",
                                                        PageCount = 45
                                                    }
                                                }
                                            },
                                            FinalQuiz = new Quiz
                                            {
                                                QuizId = 2001,
                                                Title = "کوئیز مقدماتی",
                                                Questions = new List<Question>
                                                {
                                                    new Question { QuestionId = 1, Text = "شبکه عصبی چیست؟" },
                                                    new Question { QuestionId = 2, Text = "تفاوت MLP و CNN چیست؟" }
                                                }
                                            }
                                        }
                                    },
                                    Outcomes = new List<LearningOutcome>
                                    {
                                        new LearningOutcome { Description = "درک مفاهیم پایه یادگیری ماشین" },
                                        new LearningOutcome { Description = "پیاده‌سازی مدل‌های ساده" }
                                    }
                                }
                            },
                            Instructor = new InstructorAnalytics
                            {
                                InstructorId = 401,
                                Name = "دکتر علی رضایی",
                                AvgRating = 4.8m,
                                TotalStudentsTaught = 350
                            },
                            EnrolledStudents = new List<StudentProgress>
                            {
                                new StudentProgress
                                {
                                    StudentId = 10001,
                                    FullName = "سارا احمدی",
                                    EnrolledAt = new DateTime(2025, 8, 20),
                                    ProgressPercentage = 85.5,
                                    LastActivityAt = DateTime.UtcNow.AddDays(-2),
                                    FinalGrade = new Grade { Value = 18.5m, Letter = "A" },
                                    ModuleProgresses = new Dictionary<int, ModuleProgress>
                                    {
                                        { 1001, new ModuleProgress
                                            {
                                                IsCompleted = true,
                                                CompletedAt = DateTime.UtcNow.AddDays(-5),
                                                TimeSpentSeconds = 7200,
                                                QuizAttempts = new List<QuizAttempt>
                                                {
                                                    new QuizAttempt { AttemptedAt = DateTime.UtcNow.AddDays(-6), Score = 85, OutOf = 100 },
                                                    new QuizAttempt { AttemptedAt = DateTime.UtcNow.AddDays(-5), Score = 95, OutOf = 100 }
                                                }
                                            }
                                        }
                                    }
                                }
                            },
                            Forum = new ForumAnalytics
                            {
                                TotalPosts = 120,
                                ActiveThreads = 15,
                                ResolvedQuestions = 80
                            }
                        }
                    },
                    BestInstructor = new InstructorPerformance
                    {
                        InstructorId = 401,
                        Name = "دکتر علی رضایی",
                        AvgRating = 4.8m,
                        CoursesTaught = 12
                    }
                }
            },
            TopStudents = new List<TopStudent>
            {
                new TopStudent
                {
                    StudentId = 10001,
                    Name = "سارا احمدی",
                    TotalPoints = 1500,
                    CompletedCourses = 8,
                    Badges = new BadgeCollection
                    {
                        EarnedBadges = new List<string> { "یادگیرنده برتر", "کوئیز مستر" },
                        BadgeEarnedAt = new Dictionary<string, DateTime>
                        {
                            { "یادگیرنده برتر", DateTime.UtcNow.AddMonths(-1) }
                        }
                    }
                }
            }
        }
    },

    Leaderboard = new GlobalLeaderboard
    {
        MonthlyTop = new List<TopStudent>
        {
            new TopStudent
            {
                StudentId = 10001,
                Name = "سارا احمدی",
                TotalPoints = 1500,
                CompletedCourses = 8,
                Badges = new BadgeCollection
                {
                    EarnedBadges = new List<string> { "یادگیرنده برتر" },
                    BadgeEarnedAt = new Dictionary<string, DateTime>
                    {
                        { "یادگیرنده برتر", DateTime.UtcNow.AddMonths(-1) }
                    }
                }
            }
        },
        TopInstructors = new List<TopInstructor>
        {
            new TopInstructor
            {
                InstructorId = 401,
                Name = "دکتر علی رضایی",
                AvgRating = 4.8m,
                TotalStudents = 350
            }
        }
    },

    Health = new SystemHealth
    {
        Database = new ServerStatus { IsHealthy = true, ResponseTimeMs = 12.5, LastChecked = DateTime.UtcNow.ToString() },
        Cache = new ServerStatus { IsHealthy = true, ResponseTimeMs = 5.2, LastChecked = DateTime.UtcNow.ToString() },
        VideoCdn = new ServerStatus { IsHealthy = false, ResponseTimeMs = 150.0, LastChecked = DateTime.UtcNow.ToString() },
        RecentErrors = new List<RecentError>
        {
            new RecentError
            {
                OccurredAt = DateTime.UtcNow.AddHours(-3),
                Message = "اتصال به CDN قطع شد",
                StackTrace = "در متد UploadVideo خطا رخ داد",
                Severity = "Critical"
            }
        }
    },

    RawMetrics = new Dictionary<string, object>
    {
        { "cpu_usage", 45.6 },
        { "memory_gb", 12.8 },
        { "active_sessions", 25000 }
    }
};
var snapshot3 = new ElearningPlatformAnalyticsSnapshot
{
    Info = new SnapshotInfo
    {
        SnapshotId = Guid.NewGuid(),
        CapturedAtUtc = DateTime.UtcNow,
        CapturedBy = "AnalyticsBot-v3.01",
        Environment = "Production"
    },

    Overview = new PlatformOverview
    {
        TotalStudents = 150_0001,
        ActiveToday = 25_000,
        TotalCourses = 1_200,
        TotalRevenueThisMonth = 3_500_000_000m,
        Engagement = new EngagementMetrics
        {
            AvgSessionDurationMinutes = 45.51,
            AvgCompletionRate = 0.72,
            DailyActive = new TimeSeries<DailyActiveUsers>
            {
                DataPoints = new List<DailyActiveUsers>
                {
                    new DailyActiveUsers { Date = DateTime.UtcNow.AddDays(-7), Count = 20_000 },
                    new DailyActiveUsers { Date = DateTime.UtcNow.AddDays(-1), Count = 24_500 }
                }
            }
        }
    },

    Universities = new List<UniversityAnalytics>
    {
        new UniversityAnalytics
        {
            UniversityId = 1,
            Name = "دانشگاه تهران1",
            Domain = "lms.ut.ac.ir",
            Plan = UniversityPlan.Enterprise,
            Departments = new List<DepartmentAnalytics>
            {
                new DepartmentAnalytics
                {
                    DepartmentId = 101,
                    Name = "1علوم کامپیوتر",
                    CourseInstances = new List<CourseInstanceAnalytics>
                    {
                        new CourseInstanceAnalytics
                        {
                            InstanceId = 50011,
                            Semester = "1404-1",
                            StartDate = new DateTime(2025, 9, 1),
                            EndDate = new DateTime(2026, 1, 15),
                            Template = new CourseTemplate
                            {
                                TemplateId = 301,
                                Title = "یادگیری ماشین پیشرفته",
                                Code = "CS-ML-702",
                                CreditHours = 41,
                                Difficulty = DifficultyLevel.Advanced,
                                Curriculum = new Curriculum
                                {
                                    Modules = new List<Module>
                                    {
                                        new Module
                                        {
                                            ModuleId = 10011,
                                            Title = "مقدمه بر شبکه‌های عصبی",
                                            Order = 1,
                                            Contents = new List<ContentItem>
                                            {
                                                new ContentItem
                                                {
                                                    ItemId = Guid.NewGuid(),
                                                    Title = "1ویدیو مقدماتی",
                                                    Type = ContentType.Video,
                                                    Video = new VideoContent
                                                    {
                                                        Url = "https://cdn.example.com/videos/neural-intro.mp4",
                                                        DurationSeconds = 36001,
                                                        Transcript = new Transcript
                                                        {
                                                            Language = "fa1",
                                                            Lines = new List<TranscriptLine>
                                                            {
                                                                new TranscriptLine { StartSecond = 0f, EndSecond = 10f, Text = "سلام، در این درس به شبکه‌های عصبی می‌پردازیم." },
                                                                new TranscriptLine { StartSecond = 10f, EndSecond = 20f, Text = "شبکه‌های عصبی الهام‌گرفته از مغز انسان هستند." }
                                                            }
                                                        }
                                                    }
                                                },
                                                new ContentItem
                                                {
                                                    ItemId = Guid.NewGuid(),
                                                    Title = "1اسلایدهای درس",
                                                    Type = ContentType.PDF,
                                                    Pdf = new PdfContent
                                                    {
                                                        Url = "https://cdn.example.com/pdfs/neural-slides.pdf",
                                                        PageCount = 45
                                                    }
                                                }
                                            },
                                            FinalQuiz = new Quiz
                                            {
                                                QuizId = 20011,
                                                Title = "کوئیز مقدماتی",
                                                Questions = new List<Question>
                                                {
                                                    new Question { QuestionId = 111, Text = "شبکه عصبی چیست؟" },
                                                    new Question { QuestionId = 2, Text = "تفاوت MLP و CNN چیست؟" }
                                                }
                                            }
                                        }
                                    },
                                    Outcomes = new List<LearningOutcome>
                                    {
                                        new LearningOutcome { Description = "1درک مفاهیم پایه یادگیری ماشین" },
                                        new LearningOutcome { Description = "پیاده‌سازی مدل‌های ساده" }
                                    }
                                }
                            },
                            Instructor = new InstructorAnalytics
                            {
                                InstructorId = 4011,
                                Name = "دکتر علی رضایی",
                                AvgRating = 4.8m,
                                TotalStudentsTaught = 350
                            },
                            EnrolledStudents = new List<StudentProgress>
                            {
                                new StudentProgress
                                {
                                    StudentId = 100011,
                                    FullName = "سارا احمدی",
                                    EnrolledAt = new DateTime(2025, 8, 20),
                                    ProgressPercentage = 85.5,
                                    LastActivityAt = DateTime.UtcNow.AddDays(-2),
                                    FinalGrade = new Grade { Value = 18.5m, Letter = "A1" },
                                    ModuleProgresses = new Dictionary<int, ModuleProgress>
                                    {
                                        { 1001, new ModuleProgress
                                            {
                                                IsCompleted = true,
                                                CompletedAt = DateTime.UtcNow.AddDays(-5),
                                                TimeSpentSeconds = 72001,
                                                QuizAttempts = new List<QuizAttempt>
                                                {
                                                    new QuizAttempt { AttemptedAt = DateTime.UtcNow.AddDays(-6), Score = 85, OutOf = 100 },
                                                    new QuizAttempt { AttemptedAt = DateTime.UtcNow.AddDays(-5), Score = 95, OutOf = 100 }
                                                }
                                            }
                                        }
                                    }
                                }
                            },
                            Forum = new ForumAnalytics
                            {
                                TotalPosts = 120,
                                ActiveThreads = 15,
                                ResolvedQuestions = 80
                            }
                        }
                    },
                    BestInstructor = new InstructorPerformance
                    {
                        InstructorId = 401,
                        Name = "دکتر علی رضایی",
                        AvgRating = 4.8m,
                        CoursesTaught = 12
                    }
                }
            },
            TopStudents = new List<TopStudent>
            {
                new TopStudent
                {
                    StudentId = 10001,
                    Name = "سارا احمدی",
                    TotalPoints = 1500,
                    CompletedCourses = 8,
                    Badges = new BadgeCollection
                    {
                        EarnedBadges = new List<string> { "یادگیرنده برتر", "کوئیز مستر" },
                        BadgeEarnedAt = new Dictionary<string, DateTime>
                        {
                            { "یادگیرنده برتر", DateTime.UtcNow.AddMonths(-1) }
                        }
                    }
                }
            }
        }
    },

    Leaderboard = new GlobalLeaderboard
    {
        MonthlyTop = new List<TopStudent>
        {
            new TopStudent
            {
                StudentId = 10001,
                Name = "سارا احمدی",
                TotalPoints = 1500,
                CompletedCourses = 8,
                Badges = new BadgeCollection
                {
                    EarnedBadges = new List<string> { "یادگیرنده برتر" },
                    BadgeEarnedAt = new Dictionary<string, DateTime>
                    {
                        { "یادگیرنده برتر", DateTime.UtcNow.AddMonths(-1) }
                    }
                }
            }
        },
        TopInstructors = new List<TopInstructor>
        {
            new TopInstructor
            {
                InstructorId = 401,
                Name = "دکتر علی رضایی",
                AvgRating = 4.8m,
                TotalStudents = 350
            }
        }
    },

    Health = new SystemHealth
    {
        Database = new ServerStatus { IsHealthy = true, ResponseTimeMs = 12.5, LastChecked = DateTime.UtcNow.ToString() },
        Cache = new ServerStatus { IsHealthy = true, ResponseTimeMs = 5.2, LastChecked = DateTime.UtcNow.ToString() },
        VideoCdn = new ServerStatus { IsHealthy = false, ResponseTimeMs = 150.0, LastChecked = DateTime.UtcNow.ToString() },
        RecentErrors = new List<RecentError>
        {
            new RecentError
            {
                OccurredAt = DateTime.UtcNow.AddHours(-3),
                Message = "اتصال به CDN قطع شد",
                StackTrace = "در متد UploadVideo خطا رخ داد",
                Severity = "Critical"
            }
        }
    },

    RawMetrics = new Dictionary<string, object>
    {
        { "cpu_usage", 45.6 },
        { "memory_gb", 12.8 },
        { "active_sessions", 25000 }
    }
};
var NestedRes2 = FastDiff.SmartDiffer<ElearningPlatformAnalyticsSnapshot>.GetDiffJson(snapshot2, snapshot3);
#endregion

var a = 1;