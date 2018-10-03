using RESTExercise.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace RESTExercise.Controllers
{
    [RoutePrefix("api/user")]
    public class AccountController : BaseController
    {
        //global variables
        HttpResponseMessage response = null;

        /// <summary>
        /// This function gets all the users 
        /// </summary>
        /// <returns>List<Users></returns>
        [HttpGet]
        [Route("getall")]
        public HttpResponseMessage GetUsers()
        {
            try
            {
                List<Users> users = db.Users.ToList();
                response = Request.CreateResponse(HttpStatusCode.OK, users);

                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }            
        }

        /// <summary>
        /// This function gets a user by the ID
        /// </summary>
        /// <param name="id">Is ID of the user to search</param>
        /// <returns>Users</returns>
        [HttpGet]
        [Route("get/{id}")]
        public HttpResponseMessage GetUser(string id)
        {          
            try
            {
                int idInt = Convert.ToInt32(id);
                Users user = db.Users.Where(u => u.id == idInt).FirstOrDefault();
                response = Request.CreateResponse(HttpStatusCode.OK, user);

                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        /// <summary>
        /// This function creates a user
        /// </summary>
        /// <param name="user">Object with the data to create a user</param>
        /// <returns>New User</returns>
        [HttpPost]
        [Route("create")]
        public HttpResponseMessage CreateUser(Users user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();

                Users userNew = db.Users.Where(u => u.name == user.name && u.birthdate == user.birthdate).FirstOrDefault();

                response = Request.CreateResponse(HttpStatusCode.Created, userNew);

                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        /// <summary>
        /// This function modifies a user
        /// </summary>
        /// <param name="user">Object with the data to modified a user</param>
        /// <returns>Modified User</returns>
        [HttpPut]
        [Route("update")]
        public HttpResponseMessage UpdateUser(Users user)
        {
            try
            {
                Users userUpd = db.Users.Where(u => u.id == user.id).FirstOrDefault();

                if (userUpd != null)
                {
                    db.Users.Attach(userUpd);
                    userUpd.name = user.name;
                    userUpd.birthdate = user.birthdate;
                    db.Entry(userUpd).State = EntityState.Modified;
                    db.SaveChanges();

                    response = Request.CreateResponse(HttpStatusCode.OK, user);
                }
                else
                    response = Request.CreateResponse(HttpStatusCode.NotFound, "No data found");


                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        /// <summary>
        /// This function deletes a user
        /// </summary>
        /// <param name="id">Is ID of the user for delete</param>
        [HttpDelete]
        [Route("remove/{id}")]
        public void DeleteUser(string id)
        {
            try
            {
                int idInt = Convert.ToInt32(id);
                Users user = db.Users.Where(u => u.id == idInt).FirstOrDefault();

                if(user != null)
                {
                    db.Users.Remove(user);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}