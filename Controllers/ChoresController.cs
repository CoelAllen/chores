namespace chores.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChoresController : ControllerBase
{

  private readonly ChoresService _cs;

  [HttpGet]
  public ActionResult<List<Chore>> Get()
  {
    try
    {
      var chores = _cs.GetChores();
      return Ok(chores);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  [HttpGet("{id}")]
  public ActionResult<Chore> GetChore(string id)
  {
    try
    {
      var chore = _cs.GetChore(id);
      return Ok(chore);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }


  [HttpPost]
  public ActionResult<Chore> Create([FromBody] Chore choreData)
  {
    try
    {
      Chore chore = _cs.AddChore(choreData);
      return Ok(chore);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  [HttpPut("{id}")]

  public ActionResult<Chore> Put(string id, [FromBody] Chore choreData)
  {
    try
    {
      choreData.Id = id;
      Chore chore = _cs.EditChore(choreData);
      return Ok(chore);

    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  [HttpDelete("{id}")]
  public ActionResult<Chore> Delete(string id)
  {
    try
    {
      Chore chore = _cs.DeleteChore(id);
      return Ok(chore);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  public ChoresController(ChoresService cs)
  {
    _cs = cs;
  }

}