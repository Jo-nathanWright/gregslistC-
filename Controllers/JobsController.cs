using System;
using System.Collections.Generic;
using gregslist.Models;
using gregslist.Service;
using Microsoft.AspNetCore.Mvc;

namespace gregslist.Controllers
{

    [ApiController]

    [Route("/api/[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly JobsService _jobService;

        public JobsController(JobsService jobsService)
        {
          _jobService = jobsService;
        }

        [HttpGet]

        public ActionResult<IEnumerable<Job>> Get()
        {
            try
            {
              IEnumerable<Job> jobs = _jobService.Get();
              return Ok(jobs);
            }
            catch (Exception err)
            {
              return BadRequest(err.Message);
            }
        }

        [HttpGet("{id}")]

        public ActionResult<Job> Get(string id)
        {
            try
            {
              Job found = _jobService.Get(id);
              return Ok(found);
            }
            catch (Exception err)
            {
              return BadRequest(err.Message);
            }
        }

        [HttpPost]

        public ActionResult<Job> Create([FromBody] Job rawJob)
        {
            try
            {
              Job job = _jobService.Create(rawJob);
              return Ok(job);
            }
            catch (Exception err)
            {
              return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]

        public ActionResult<Job> Delete(string id)
        {
            try
            {
              _jobService.Delete(id);
              return Ok("Successfully Deleted That Job Listing");
            }
            catch (Exception err)
            {
              return BadRequest(err.Message);
            }
        }
    }
}