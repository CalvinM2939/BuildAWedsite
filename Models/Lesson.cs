namespace BuildAWebsite.Models;

public record Lesson(int Number, string Title, string Summary, string Page);

public static class LessonData
{
    public static readonly List<Lesson> All =
    [
        new(1, "What Is a Website?", "What happens when you type an the address.", "/Lessons/WhatIsAWebsite"),
        new(2, "HTML", "The things that tell a browser what is on a page.", "/Lessons/Html"),
        new(3, "CSS", "How to add colors, fonts, and spacing.", "/Lessons/Css"),
        new(4, "C# and Razor", "How to make pages that can count and make choices.", "/Lessons/Razor"),
    ];
}
