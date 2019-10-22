namespace EnterpriseNumberGetter.Tests
{
    public class MockInputManager : IInputManager
    {
        public string _mockInput;
        public MockInputManager(string mockInput)
        {
            _mockInput = mockInput;
        }

        public string GetInput()
        {
            return _mockInput;
        }       
    }
}