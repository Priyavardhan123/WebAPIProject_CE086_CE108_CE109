using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AttendanceManager.Models;

namespace AttendanceManager.Controllers
{
    public class SubjectController : ApiController
    {
        SubjectDataClassesDataContext db = new SubjectDataClassesDataContext();

        public IEnumerable<SubjectTable> Get()
        {
            return db.SubjectTables.ToList().AsEnumerable() ;
        }

        public HttpResponseMessage Get(int id)
        {
            var subjectdetail = (from a in db.SubjectTables where a.ID == id select a).FirstOrDefault();

            if (subjectdetail != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, subjectdetail);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Code or Subject Not Found");
            }
        }

        //To add a new Subject record  
        // POST api/<controller>  
        public HttpResponseMessage Post([FromBody]SubjectTable sub)
        {
            try
            {
                db.SubjectTables.InsertOnSubmit(sub);

                db.SubmitChanges();

                var msg = Request.CreateResponse(HttpStatusCode.Created, sub);

                msg.Headers.Location = new Uri(Request.RequestUri + sub.ID.ToString());

                return msg;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        //To update Subject record  
        // PUT api/<controller>/5  
        public HttpResponseMessage Put(int id, [FromBody]SubjectTable sub)
        {
            var subjectdetail = (from a in db.SubjectTables where a.ID == id select a).FirstOrDefault();

            if (subjectdetail != null)
            {
                subjectdetail.Attended_lectures = sub.Attended_lectures;
                subjectdetail.Required_attendance = sub.Required_attendance;
                subjectdetail.Total_lectures = sub.Total_lectures;
                db.SubmitChanges();

                return Request.CreateResponse(HttpStatusCode.OK, subjectdetail);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid Code or Subject Not Found");
            }
        }

        // DELETE api/<controller>/5  
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var _DeleteSubject = (from a in db.SubjectTables where a.ID == id select a).FirstOrDefault();

                if (_DeleteSubject != null)
                {

                    db.SubjectTables.DeleteOnSubmit(_DeleteSubject);
                    db.SubmitChanges();

                    return Request.CreateResponse(HttpStatusCode.OK, id);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Subject Not Found or Invalid " + id.ToString());
                }
            }

            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }
    }
}
