using builder_pattern.Abstract;
using builder_pattern.Model;

namespace builder_pattern.Concrete
{
    public class WatchBuilder : IWatchBuilder
    {
        private AppleWatch _appleWatch = new();

        public WatchBuilder()
        {
            Reset();
        }

        private void Reset() => _appleWatch = new();

        public void BuildWatchColor() => _appleWatch.Color = "black";

        public void BuildWatchSize() => _appleWatch.Size = "44mm";

        public void BuildWatchType() => _appleWatch.Type = "Titanium";

        public AppleWatch GetWatch()
        {
            AppleWatch appleWatch = _appleWatch;

            Reset();

            return appleWatch;
        }
    }
}
