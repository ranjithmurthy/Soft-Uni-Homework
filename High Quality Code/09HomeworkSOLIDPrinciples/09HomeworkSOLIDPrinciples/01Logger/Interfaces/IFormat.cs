﻿namespace _01Logger.Interfaces
{
    using System;

    using _01Logger.Enums;

    public interface ILayout
    {
        string Format(string message, ReportLevel level, DateTime date);
    }
}
