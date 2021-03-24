namespace UnitTests
{
    using Moq;
    using Moq.AutoMock;
    using Xunit;

    public class RolRepositoryTests
    {
        private readonly AutoMocker _mocker;

        public RolRepositoryTests()
        {
            _mocker = new AutoMocker(MockBehavior.Strict);
        }

        [Fact]
        public void Get_ExistingId_ReturnsRol()
        {
            // Arrange
            //_mocker.GetMock<IUserDomainService>()
            //    .Setup(x => x.Get(userId))
            //    .Returns(new User { Name = expectedName, Surname = expectedSurname });

            //// Act
            //User actual = _service.Get(userId);

            //// Assert
            //new
            //{
            //    Name = expectedName,
            //    Surname = expectedSurname
            //}.ToExpectedObject().ShouldMatch(actual);

            //_mocker.GetMock<IUserDomainService>()
            //    .Verify(x => x.Get(userId), Times.Once);
        }
    }
}
