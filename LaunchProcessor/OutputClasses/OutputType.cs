namespace LaunchProcessor.OutputClasses
{
    public abstract class OutputType
    {
        #region Public Functions

        public void InitializeOutput() { ovr_InitializeOutput(); }
        public void OutputText(string text) { ovr_OutputText(text); }
        public void UninitializeOutput() { ovr_UninitializeOutput(); }

        #endregion Public Functions

        #region Abstract Functions

        protected abstract void ovr_InitializeOutput();
        protected abstract void ovr_OutputText(string text);
        protected abstract void ovr_UninitializeOutput();

        #endregion Abstract Functions
    }
}
