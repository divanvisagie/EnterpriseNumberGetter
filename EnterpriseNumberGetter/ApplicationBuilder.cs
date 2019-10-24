using EnterpriseNumberGetter.Core;

namespace EnterpriseNumberGetter
{
    public class ApplicationBuilder
    {
        private Application _application = new Application();

        public ApplicationBuilder AddInputManager(IInputManager inputManager)
        {
            _application.InputManager = inputManager;
            return this;
        }

        public ApplicationBuilder AddDisplayManager(IDisplayManager displayManager) 
        {
            _application.DisplayManager = displayManager;
            return this;
        }

        public Application Build() 
        {
            _application.NumberGetter = new NumberGetter(_application.InputManager, _application.DisplayManager);
            return _application;
        }
    }
}
