/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 05/09/2016
 * Time: 8:55 CH
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


using System.Windows.Forms;
using Facebook;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Net;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Chrome;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections;
using Newtonsoft.Json;

namespace Another
{

	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public string json {get; set;}

		public static string urlPermits = "https://m.facebook.com/v1.0/dialog/oauth?redirect_uri=https://account.nokia.com/Copy_this_whole_url_www.facebook.com&scope=email,publish_actions,user_about_me,user_actions.books,user_actions.music,user_actions.news,user_actions.video,user_activities,user_birthday,user_education_history,user_events,user_games_activity,user_groups,user_hometown,user_interests,user_likes,user_location,user_notes,user_photos,user_questions,user_relationship_details,user_relationships,user_religion_politics,user_status,user_subscriptions,user_videos,user_website,user_work_history,friends_about_me,friends_actions.books,friends_actions.music,friends_actions.news,friends_actions.video,friends_activities,friends_birthday,friends_education_history,friends_events,friends_games_activity,friends_groups,friends_hometown,friends_interests,friends_likes,friends_location,friends_notes,friends_photos,friends_questions,friends_relationship_details,friends_relationships,friends_religion_politics,friends_status,friends_subscriptions,friends_videos,friends_website,friends_work_history,ads_management,create_event,create_note,export_stream,friends_online_presence,manage_friendlists,manage_notifications,manage_pages,photo_upload,publish_stream,read_friendlists,read_insights,read_mailbox,read_page_mailboxes,read_requests,read_stream,rsvp_event,share_item,sms,status_update,user_online_presence,video_upload,xmpp_login&response_type=token%20code&client_id=200758583311692" ;
		public static string urlAccessToken = "https://developers.facebook.com/tools/debug/accesstoken/?app_id=200758583311692";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			/*string[] theCookies = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
foreach (string currentFile in theCookies)
{
   try
   {
      System.IO.File.Delete(currentFile);
   }
   catch (Exception ex)
   {
   }
}*/
		
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			FacebookClient client = new FacebookClient(textBox1.Text);
			dynamic me = client.Get("me");
			string id = me.id;
			string name = me.name;
			string email = me.email;
			string birthday = me.birthday;
			
			for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++){
				switch ((string)checkedListBox1.CheckedItems[i]) {
					case "Email":
						listBox1.Items.Add("Email:"+ email);
						break;
					case "Birthday":
						listBox1.Items.Add("Birthday:"+birthday);
						break;
					case "Id":
						listBox1.Items.Add("ID:"+id);
						break;
					case "Name":
						listBox1.Items.Add("Name:"+name);
						break;
					default:
						
						break;
				}
			}
		}
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
		}
		void CheckedListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		void Button3Click(object sender, EventArgs e)
		{
			var client = new FacebookClient(textBox1.Text);
			
			dynamic result = client.Post("/me/feed", new { message = textBox2.Text });
			
		}
		
		void WebBrowser1DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			
		}
		private bool IsElementPresent(By by)
    {
        try
        {
        	IWebDriver driver = new PhantomJSDriver();
            driver.FindElement(by);
            return true;
        }
        catch (NoSuchElementException)
        {
        	MessageBox.Show("ERROR !");
        	
        	
            return false;
            
        }
    }
		
		void Button5Click(object sender, EventArgs e)
		{
			
			
		
	
		}
		void ListBox2SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		async void Button6Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textEmail.Text) || string.IsNullOrWhiteSpace(textPass.Text)){
				MessageBox.Show("Please fill out the Login form!");
			} else {
			IWebDriver driver = new PhantomJSDriver();
			
			driver.Navigate().GoToUrl("https://www.facebook.com");
			LoginFacebook(driver);
			driver.Navigate().GoToUrl(urlPermits);
			await PutTaskDelay();
			/*if(driver.FindElements(By.CssSelector("[action='/v2.0/dialog/oauth/confirm']")).Count != 0 ) {
			driver.FindElement(By.Name("__CONFIRM__")).Click();
			} else {
			driver.FindElement(By.Name("__CONFIRM__")).Click();
			await PutTaskDelay();
			driver.FindElement(By.Name("__CONFIRM__")).Click();
			await PutTaskDelay();
			driver.FindElement(By.Name("__CONFIRM__")).Click();
			await PutTaskDelay();
			}
			driver.Navigate().GoToUrl(urlAccessToken);
			
			
			IWebElement query = driver.FindElement(By.Name("q"));
			string AccessToken = query.GetAttribute("value");
			*/
			string accessUrl = driver.Url;
			string AccessToken = accessUrl.Split(new char[] { '=' }, 2).Last();
			textBox1.Text = AccessToken;
			driver.Quit();
			
			
			
			
			
			}
		}
		void Button7Click(object sender, EventArgs e)
		{
			
		}
		
		void ListBox4SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox4TextChanged(object sender, EventArgs e)
		{
	
		}
		private void LoginFacebook (IWebDriver driver)
		{
			
			
			IWebElement email = driver.FindElement(By.Name("email"));
			email.SendKeys(textEmail.Text);
			IWebElement pass = driver.FindElement(By.Name("pass"));
			pass.SendKeys(textPass.Text);
			IWebElement loginBtn = driver.FindElement(By.Id("loginbutton"));
			loginBtn.Click();
		}
		
		async Task PutTaskDelay()
		{
    		await Task.Delay(4000);
		}
		void Button4Click(object sender, EventArgs e)
		{
			listName.Items.Clear();
			using (WebClient wc = new WebClient())
		{
			wc.Headers.Add("Accept-Language", " en-US");
       		wc.Headers.Add("Accept", " text/html, application/xhtml+xml, */*");
        	wc.Headers.Add("User-Agent", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)");
  			 string s = wc.DownloadString("https://graph.facebook.com/me/inbox?access_token=" + textBox1.Text);
  			 json = s;
  			 dynamic messages = JsonConvert.DeserializeObject(json);
  			 
  			
  			 var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
			Dictionary<string,object> csObj = serializer.Deserialize<Dictionary<string,object>>(json);
			int length = ((ArrayList)csObj["data"]).Count; 
  			 
  			 
  			 for (int i = 0; i < length; i ++ ){
  			
  			 string messager = messages.data[0].comments.data[i].from.name.Value;
  			 JObject comment =  messages.data[0].comments.data[i];
  			 JArray friendName = messages.data[i].to.data;
  			 string id = messages.data[i].id.Value;
  			 if (friendName.Count > 2){
  			 	listName.Items.Add("A Group" + ":" + id);
  			 } else {
  			 	string friendsName = messages.data[i].to.data[0].name.Value;
  			 	
  			 	listName.Items.Add(friendsName + ":"  +id);
  			 }
  			 
  			 
  			 
  			 
  			 
		
		}
  			 }
			}
		void ListNameSelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void ListNameClick(object sender, EventArgs e)
		{
			
		}
		void ListNameDoubleClick(object sender, EventArgs e)
		{
			listChat.Items.Clear();
				
  			 dynamic messages = JsonConvert.DeserializeObject(json);
  			 
  			 
  			 try{
			if (listName.SelectedItem != null)
			{
				string sub = listName.SelectedItem.ToString().Split(':').Last();
				JToken id = messages.SelectToken("$.data[?(@.id == '"+ sub +"')]");
				
				dynamic curMess = JsonConvert.DeserializeObject(id.ToString());
				JObject mymess = curMess.comments;
				string mess = mymess.ToString();
				var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
				Dictionary<string,object> csObj = serializer.Deserialize<Dictionary<string,object>>(mess);
				int length = ((ArrayList)csObj["data"]).Count; 
				for(int i = 0; i < length; i ++){
					JObject comments = curMess.comments.data[i];
					string messSender = curMess.comments.data[i].from.name.Value;
					if (comments["message"] != null)
  			 		{
					
					string messS = curMess.comments.data[i].message.Value;
					
					listChat.Items.Add(messSender + ": " + messS);
					} 
					else {
					listChat.Items.Add(messSender + ": <An Icon>" );
					}
				}
			}
  			 } catch (Exception ex){}
		} 
		
		void BtnGetPerClick(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(textEmail.Text) || string.IsNullOrWhiteSpace(textPass.Text)){
				MessageBox.Show("Please fill out the Login form!");
			} else {
			IWebDriver driver = new ChromeDriver();
			driver.Navigate().GoToUrl(urlPermits);
			LoginFacebook(driver);
			DialogResult d = MessageBox.Show("When you done permiting, click 'OK' button", "Alert", MessageBoxButtons.OK);
			if(d == DialogResult.OK)
			{
				driver.Quit();
			}
			
			}
				
		}
	
		}		
    }


