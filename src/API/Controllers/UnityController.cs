using System.Security.Claims;
using Application.UseCases;
using Domain.Dtos;
using Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/unity")]
[ApiController]
[Authorize]
public class UnityController(IUnityRepository unityRepository, GetUnityUseCase getUnityUseCase) : ControllerBase
{
    [HttpGet("get-all")]
    public async Task<IActionResult> GetAllUnities()
    {
        var unities = await unityRepository.GetListAsync(u => true);
        return Ok(unities.Select(unity => new UnityDtoOut
        {
            PublicId = unity.PublicId,
            Name = unity.Name,
            Description = unity.Description,
        }));
    }

    [HttpGet("get-from-name")]
    public async Task<IActionResult> GetUnity([FromQuery] string unityName)
    {
        var publicUserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value!;
        var result = await getUnityUseCase.ExecuteAsync(unityName, Guid.Parse(publicUserId));
        return StatusCode((int)result.StatusCode, result.Content);
    }
}
