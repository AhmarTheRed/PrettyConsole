using System;

namespace PrettyConsole
{
    public class ConsoleWrapper
    {
        // Defaults
        private readonly ConsoleColor _successColour = ConsoleColor.DarkGreen;
        private readonly ConsoleColor _warningColour = ConsoleColor.DarkYellow;
        private readonly ConsoleColor _errorColour = ConsoleColor.DarkRed;

        public ConsoleWrapper()
        {
        }

        public ConsoleWrapper(ConsoleColor successColour, ConsoleColor warningColour, ConsoleColor errorColour)
        {
            _successColour = successColour;
            _warningColour = warningColour;
            _errorColour = errorColour;
        }

        public void WriteSuccessLine(string value)
        {
            WriteColourFormattedLine(value, _successColour);
        }

        public void WriteSuccessLineInverted(string value)
        {
            WriteColourFormattedLineInverted(value, _successColour);
        }

        public void WriteWarningLine(string value)
        {
            WriteColourFormattedLine(value, _warningColour);
        }

        public void WriteWarningLineInverted(string value)
        {
            WriteColourFormattedLineInverted(value, _warningColour);
        }

        public void WriteErrorLine(string value)
        {
            WriteColourFormattedLine(value, _errorColour);
        }

        public void WriteErrorLineInverted(string value)
        {
            WriteColourFormattedLineInverted(value, _errorColour);
        }

        private void WriteColourFormattedLineInverted(string value, ConsoleColor consoleColour)
        {
            Console.BackgroundColor = consoleColour;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        private void WriteColourFormattedLine(string value, ConsoleColor consoleColour)
        {
            Console.ForegroundColor = consoleColour;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                Console.ResetColor();

                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
        }
        #endregion
    }
}
