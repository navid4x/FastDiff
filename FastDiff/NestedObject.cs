using System;
using System.Collections.Generic;

public class ElearningPlatformAnalyticsSnapshot
{
    public SnapshotInfo Info { get; set; } = new SnapshotInfo();
    public PlatformOverview Overview { get; set; } = new PlatformOverview();
    public List<UniversityAnalytics> Universities { get; set; } = new List<UniversityAnalytics>();
    public GlobalLeaderboard Leaderboard { get; set; } = new GlobalLeaderboard();
    public SystemHealth Health { get; set; } = new SystemHealth();
    public Dictionary<string, object> RawMetrics { get; set; } = new Dictionary<string, object>();
}

public class SnapshotInfo
{
    public Guid SnapshotId { get; set; }
    public DateTime CapturedAtUtc { get; set; }
    public string CapturedBy { get; set; } = string.Empty;
    public string Environment { get; set; } = string.Empty; // Production, Staging
}

public class PlatformOverview
{
    public int TotalStudents { get; set; }
    public int ActiveToday { get; set; }
    public int TotalCourses { get; set; }
    public decimal TotalRevenueThisMonth { get; set; }
    public EngagementMetrics Engagement { get; set; } = new EngagementMetrics();
}

public class EngagementMetrics
{
    public double AvgSessionDurationMinutes { get; set; }
    public double AvgCompletionRate { get; set; }
    public TimeSeries<DailyActiveUsers> DailyActive { get; set; } = new TimeSeries<DailyActiveUsers>();
}

public class TimeSeries<T>
{
    public List<T> DataPoints { get; set; } = new List<T>();
}

public class DailyActiveUsers
{
    public DateTime Date { get; set; }
    public int Count { get; set; }
}

public class UniversityAnalytics
{
    public int UniversityId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Domain { get; set; } = string.Empty;
    public UniversityPlan Plan { get; set; }

    public List<DepartmentAnalytics> Departments { get; set; } = new List<DepartmentAnalytics>();
    public List<TopStudent> TopStudents { get; set; } = new List<TopStudent>();
}

public class DepartmentAnalytics
{
    public int DepartmentId { get; set; }
    public string Name { get; set; } = string.Empty;

    public List<CourseInstanceAnalytics> CourseInstances { get; set; } = new List<CourseInstanceAnalytics>();
    public InstructorPerformance? BestInstructor { get; set; }
}

public class CourseInstanceAnalytics
{
    public int InstanceId { get; set; }
    public string Semester { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public CourseTemplate Template { get; set; } = new CourseTemplate();
    public InstructorAnalytics Instructor { get; set; } = new InstructorAnalytics();
    public List<StudentProgress> EnrolledStudents { get; set; } = new List<StudentProgress>();
    public ForumAnalytics Forum { get; set; } = new ForumAnalytics();
}

public class CourseTemplate
{
    public int TemplateId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public int CreditHours { get; set; }
    public DifficultyLevel Difficulty { get; set; }

    public Curriculum Curriculum { get; set; } = new Curriculum();
}

public class Curriculum
{
    public List<Module> Modules { get; set; } = new List<Module>();
    public List<LearningOutcome> Outcomes { get; set; } = new List<LearningOutcome>();
}

public class LearningOutcome
{
    public string Description { get; set; } = string.Empty;
}

public class Module
{
    public int ModuleId { get; set; }
    public string Title { get; set; } = string.Empty;
    public int Order { get; set; }

    public List<ContentItem> Contents { get; set; } = new List<ContentItem>();
    public Quiz? FinalQuiz { get; set; }
}

public class ContentItem
{
    public Guid ItemId { get; set; }
    public string Title { get; set; } = string.Empty;
    public ContentType Type { get; set; }

    public VideoContent? Video { get; set; }
    public PdfContent? Pdf { get; set; }
    public LiveSessionInfo? LiveSession { get; set; }
}

public class VideoContent
{
    public string Url { get; set; } = string.Empty;
    public int DurationSeconds { get; set; }
    public Transcript Transcript { get; set; } = new Transcript();
}

public class Transcript
{
    public string Language { get; set; } = string.Empty;
    public List<TranscriptLine> Lines { get; set; } = new List<TranscriptLine>();
}

public class TranscriptLine
{
    public float StartSecond { get; set; }
    public float EndSecond { get; set; }
    public string Text { get; set; } = string.Empty;
}

public class PdfContent
{
    public string Url { get; set; } = string.Empty;
    public int PageCount { get; set; }
}

public class LiveSessionInfo
{
    public DateTime ScheduledAt { get; set; }
    public string MeetingLink { get; set; } = string.Empty;
}

public class Quiz
{
    public int QuizId { get; set; }
    public string Title { get; set; } = string.Empty;
    public List<Question> Questions { get; set; } = new List<Question>();
}

public class Question
{
    public int QuestionId { get; set; }
    public string Text { get; set; } = string.Empty;
}

public class InstructorAnalytics
{
    public int InstructorId { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal AvgRating { get; set; }
    public int TotalStudentsTaught { get; set; }
}

public class ForumAnalytics
{
    public int TotalPosts { get; set; }
    public int ActiveThreads { get; set; }
    public int ResolvedQuestions { get; set; }
}

public class StudentProgress
{
    public int StudentId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public DateTime EnrolledAt { get; set; }
    public double ProgressPercentage { get; set; }
    public DateTime? LastActivityAt { get; set; }
    public Grade? FinalGrade { get; set; }

    public Dictionary<int, ModuleProgress> ModuleProgresses { get; set; } = new Dictionary<int, ModuleProgress>();
}

public class ModuleProgress
{
    public bool IsCompleted { get; set; }
    public DateTime? CompletedAt { get; set; }
    public int TimeSpentSeconds { get; set; }
    public List<QuizAttempt> QuizAttempts { get; set; } = new List<QuizAttempt>();
}

public class QuizAttempt
{
    public DateTime AttemptedAt { get; set; }
    public int Score { get; set; }
    public int OutOf { get; set; }
}

public class Grade
{
    public decimal Value { get; set; }
    public string Letter { get; set; } = string.Empty; // e.g., "A+", "B-"
}

public class InstructorPerformance
{
    public int InstructorId { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal AvgRating { get; set; }
    public int CoursesTaught { get; set; }
}

public class GlobalLeaderboard
{
    public List<TopStudent> MonthlyTop { get; set; } = new List<TopStudent>();
    public List<TopInstructor> TopInstructors { get; set; } = new List<TopInstructor>();
}

public class TopStudent
{
    public int StudentId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int TotalPoints { get; set; }
    public int CompletedCourses { get; set; }
    public BadgeCollection Badges { get; set; } = new BadgeCollection();
}

public class BadgeCollection
{
    public List<string> EarnedBadges { get; set; } = new List<string>();
    public Dictionary<string, DateTime> BadgeEarnedAt { get; set; } = new Dictionary<string, DateTime>();
}

public class TopInstructor
{
    public int InstructorId { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal AvgRating { get; set; }
    public int TotalStudents { get; set; }
}

public class SystemHealth
{
    public ServerStatus Database { get; set; } = new ServerStatus();
    public ServerStatus Cache { get; set; } = new ServerStatus();
    public ServerStatus VideoCdn { get; set; } = new ServerStatus();
    public List<RecentError> RecentErrors { get; set; } = new List<RecentError>();
}

public class ServerStatus
{
    public bool IsHealthy { get; set; }
    public double ResponseTimeMs { get; set; }
    public string LastChecked { get; set; } = string.Empty;
}

public class RecentError
{
    public DateTime OccurredAt { get; set; }
    public string Message { get; set; } = string.Empty;
    public string StackTrace { get; set; } = string.Empty;
    public string Severity { get; set; } = string.Empty; // e.g., "Warning", "Critical"
}

// Enums
public enum UniversityPlan { Free, Pro, Enterprise }
public enum DifficultyLevel { Beginner, Intermediate, Advanced, Expert }
public enum ContentType { Video, PDF, Interactive, LiveSession, Quiz }