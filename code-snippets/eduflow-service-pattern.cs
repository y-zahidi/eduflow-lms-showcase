// EduFlow LMS - illustrative excerpt only.
// This is a compact portfolio snippet, not the full project source.

public sealed class CourseRecommendationService
{
    private readonly ICourseRepository _courses;
    private readonly IEnrollmentRepository _enrollments;

    public CourseRecommendationService(
        ICourseRepository courses,
        IEnrollmentRepository enrollments)
    {
        _courses = courses;
        _enrollments = enrollments;
    }

    public async Task<ServiceResult<IReadOnlyList<CourseCardDto>>> RecommendAsync(
        int learnerId,
        CancellationToken cancellationToken = default)
    {
        var learnerThemes = await _enrollments.GetPreferredThemesAsync(learnerId, cancellationToken);

        var courses = learnerThemes.Count == 0
            ? await _courses.GetTrendingAsync(limit: 6, cancellationToken)
            : await _courses.GetByThemesAsync(learnerThemes, limit: 6, cancellationToken);

        var cards = courses
            .Select(course => new CourseCardDto(course.Id, course.Title, course.ThemeName))
            .ToList();

        return ServiceResult.Success<IReadOnlyList<CourseCardDto>>(cards);
    }
}

