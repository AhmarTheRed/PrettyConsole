using System;

namespace PrettyConsole
{
    public interface IConsoleWrapper : IDisposable
    {
        void WriteErrorLine(string value);
        void WriteErrorLineInverted(string value);
        void WriteSuccessLine(string value);
        void WriteSuccessLineInverted(string value);
        void WriteWarningLine(string value);
        void WriteWarningLineInverted(string value);
    }
}