using builder_pattern.Abstract;

namespace builder_pattern.Concrete
{
    public class Director
    {
        private IWatchBuilder _watchBuilder;
        private IStrapBuilder _strapBuilder;

        public IWatchBuilder WatchBuilder { set { _watchBuilder = value; } }
        public IStrapBuilder StrapBuilder { set { _strapBuilder = value; } }

        public void BuildRedAppleWatch() {
            _watchBuilder.BuildWatchColor();
        }
    }
}
