using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTExercise
{
    public partial class Form1 : Form
    {
        //global variables
        int compNumber = 0;
        DateTime compDate = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function gets all the users 
        /// </summary>
        private void btnAllUser_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:56471");
                    MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                    string rt = string.Format("{0}/{1}", client.BaseAddress.AbsoluteUri, "api/user/getall");
                    HttpResponseMessage response = client.GetAsync(rt).Result;

                    //Get List Users
                    var stringData = response.Content.ReadAsStringAsync().Result;

                    if (stringData != "null")
                    {
                        List<Users> users = JsonConvert.DeserializeObject<List<Users>>(stringData);
                        resultGetAllUsers.Text = "";

                        foreach (Users user in users)
                        {
                            resultGetAllUsers.Text = resultGetAllUsers.Text + user.id + " " + user.name + " " + user.birthdate.ToString("d") + "\r\n";
                        }
                    }
                    else
                        resultGetAllUsers.Text = "No data found";
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    throw new Exception(String.Format("Exception: {0} | {1}", ex.Message.ToString(), ex.InnerException.ToString()));
                else
                    throw new Exception(String.Format("Exception: {0}", ex.Message));
            }        
        }

        /// <summary>
        /// This function gets a user by the ID
        /// </summary>
        private void btnGetUser_Click(object sender, EventArgs e)
        {
            if( tbGetUser.Text != "")
            {
                if (int.TryParse(tbGetUser.Text, out compNumber))
                {
                    try
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            client.BaseAddress = new Uri("http://localhost:56471");
                            MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");


                            string rt = string.Format("{0}/{1}", client.BaseAddress.AbsoluteUri, "api/user/get/" + tbGetUser.Text);
                            HttpResponseMessage response = client.GetAsync(rt).Result;

                            //Get User
                            var stringData = response.Content.ReadAsStringAsync().Result;

                            if (stringData != "null")
                            {
                                Users user = JsonConvert.DeserializeObject<Users>(stringData);

                                resultGetUser.Text = user.id + " " + user.name + " " + user.birthdate.ToString("d");
                            }
                            else
                                resultGetUser.Text = "No data found";
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex.InnerException != null)
                            throw new Exception(String.Format("Exception: {0} | {1}", ex.Message.ToString(), ex.InnerException.ToString()));
                        else
                            throw new Exception(String.Format("Exception: {0}", ex.Message));
                    }
                }
                else
                {
                    resultGetUser.Text = "Error!! The data not is number";
                }
            }        
            else
            {
                resultGetUser.Text = "Error!! Enter the data";
            }
        }

        /// <summary>
        /// This function creates a user
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "" && tbBD.Text != "")
            {
                if (DateTime.TryParse(tbBD.Text, out compDate))
                {
                    try
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            client.BaseAddress = new Uri("http://localhost:56471");
                            MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                            string rt = string.Format("{0}/{1}", client.BaseAddress.AbsoluteUri, "api/user/create");

                            Users userNew = new Users();
                            userNew.name = tbName.Text;

                            userNew.birthdate = Convert.ToDateTime(tbBD.Text);

                            var myContent = JsonConvert.SerializeObject(userNew);
                            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                            var byteContent = new ByteArrayContent(buffer);
                            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                            HttpResponseMessage response = client.PostAsync(rt, byteContent).Result;

                            //Get User
                            var stringData = response.Content.ReadAsStringAsync().Result;

                            if (stringData != "null")
                            {
                                Users user = JsonConvert.DeserializeObject<Users>(stringData);

                                resultCreate.Text = user.id + " " + user.name + " " + user.birthdate.ToString("d");
                            }
                            else
                                resultCreate.Text = "No data found";
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex.InnerException != null)
                            throw new Exception(String.Format("Exception: {0} | {1}", ex.Message.ToString(), ex.InnerException.ToString()));
                        else
                            throw new Exception(String.Format("Exception: {0}", ex.Message));
                    }
                }            
                else
                {
                    resultCreate.Text = "Error!! The data not is date";
                }
            }
            else
            {
                resultCreate.Text = "Error!! Enter the data";
            }
        }

        /// <summary>
        /// This function modifies a user
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbUPName.Text != "" && tbUPBD.Text != "" && tbUPID.Text != "")
            {
                if (int.TryParse(tbUPID.Text, out compNumber))
                {
                    if (DateTime.TryParse(tbUPBD.Text, out compDate))
                    {
                        try
                        {
                            using (HttpClient client = new HttpClient())
                            {
                                client.BaseAddress = new Uri("http://localhost:56471");
                                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                                string rt = string.Format("{0}/{1}", client.BaseAddress.AbsoluteUri, "api/user/update");

                                Users userNew = new Users();
                                userNew.id = Convert.ToInt32(tbUPID.Text);
                                userNew.name = tbUPName.Text;
                                userNew.birthdate = Convert.ToDateTime(tbUPBD.Text);

                                var myContent = JsonConvert.SerializeObject(userNew);
                                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                                var byteContent = new ByteArrayContent(buffer);
                                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                                HttpResponseMessage response = client.PutAsync(rt, byteContent).Result;

                                //Get User
                                var stringData = response.Content.ReadAsStringAsync().Result;

                                if (stringData != "null")
                                {
                                    Users user = JsonConvert.DeserializeObject<Users>(stringData);

                                    resultUpdate.Text = user.id + " " + user.name + " " + user.birthdate.ToString("d");
                                }
                                else
                                    resultUpdate.Text = "No data found";
                            }
                        }
                        catch (Exception ex)
                        {
                            if (ex.InnerException != null)
                                throw new Exception(String.Format("Exception: {0} | {1}", ex.Message.ToString(), ex.InnerException.ToString()));
                            else
                                throw new Exception(String.Format("Exception: {0}", ex.Message));
                        }
                    
                    }
                    else
                    {
                        resultUpdate.Text = "Error!! The data not is date";
                    }
                }
                else
                {
                    resultUpdate.Text = "Error!! The data not is number";
                }
            }
            else
            {
                resultUpdate.Text = "Error!! Enter the data";
            }
        }

        /// <summary>
        /// This function deletes a user
        /// </summary>
        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (tbDLID.Text != "")
            {
                if (int.TryParse(tbDLID.Text, out compNumber))
                {
                    try
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            client.BaseAddress = new Uri("http://localhost:56471");
                            MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
                            string rt = string.Format("{0}/{1}", client.BaseAddress.AbsoluteUri, "api/user/remove/" + tbDLID.Text);
                            HttpResponseMessage response = client.DeleteAsync(rt).Result;
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex.InnerException != null)
                            throw new Exception(String.Format("Exception: {0} | {1}", ex.Message.ToString(), ex.InnerException.ToString()));
                        else
                            throw new Exception(String.Format("Exception: {0}", ex.Message));
                    }
                
                }
                else
                {
                    resultRemove.Text = "Error!! The data not is number";
                }
            }
            else
            {
                resultRemove.Text = "Error!! Enter the data";
            }
        }
    }
}
