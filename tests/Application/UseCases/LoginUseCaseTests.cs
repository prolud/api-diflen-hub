using System.Net;
using Application.UseCases;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using FluentAssertions;
using Moq;

namespace Tests.Application.UseCases
{
    public class LoginUseCaseTests
    {
        private readonly Mock<IUserRepository> _userRepository = new();
        private readonly Mock<IJwtService> _jwtService = new();
        private readonly LoginUseCase _useCase;

        public LoginUseCaseTests()
        {
            _useCase = new(_userRepository.Object, _jwtService.Object);
        }

        [Fact]
        public async Task ExecuteAsync_ShouldReturnNotFound_WhenUserNotFound()
        {
            // Given

            // When
            var result = await _useCase.ExecuteAsync("Any e-mail", "Any password");

            // Then
            result.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
            result.Content.Should().BeEquivalentTo("Usuário não encontrado");
        }
    }
}