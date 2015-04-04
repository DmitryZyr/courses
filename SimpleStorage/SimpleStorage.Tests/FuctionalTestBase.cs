using Domain;
using NUnit.Framework;
using SimpleStorage.Infrastructure;
using SimpleStorage.IoC;

namespace SimpleStorage.Tests
{
    [TestFixture]
    public abstract class FuctionalTestBase
    {
        [SetUp]
        public virtual void SetUp()
        {
            var container = IoCFactory.GetContainer();

            container.Configure(c => c.For<IStateRepository>().Use(new StateRepository()));

            var operationLog = new OperationLog();
            container.Configure(c => c.For<IOperationLog>().Use(operationLog));

            var storage = new Storage(operationLog, new ValueComparer());
            container.Configure(c => c.For<IStorage>().Use(storage));
        }
    }
}