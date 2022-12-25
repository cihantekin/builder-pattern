using builder_pattern.Abstract;
using builder_pattern.Model;

namespace builder_pattern.Concrete
{
    public class StrapBuilder : IStrapBuilder
    {
        private AppleWatch _appleWatch;
        public StrapBuilder(AppleWatch appleWatch)
        {
            _appleWatch = appleWatch;
        }

        public void BuildStrapSize() => _appleWatch.StrapSize = "10mm";

        public void BuildStrapType() => _appleWatch.StrapType = "Classic";

        public void BuildWatchStrapColor() => _appleWatch.StrapColor = "red";

        public AppleWatch GetWatch()
        {
            AppleWatch appleWatch = _appleWatch;

            _appleWatch = new();

            return appleWatch;
        }
    }
}
