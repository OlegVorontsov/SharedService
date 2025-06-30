using Microsoft.AspNetCore.Mvc;

namespace SharedService.Framework;

[ApiController]
[Route("api/[controller]")]
public abstract class ApplicationController : ControllerBase;