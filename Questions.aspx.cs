using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Body : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String savedScore = Request["userCounter"].ToString();
                userScore.Text = savedScore;
                int temp = int.Parse(userScore.Text);
                questions(temp);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(userScore.Text);
            temp = temp + 1;
            userScore.Text = temp.ToString();
            questions(temp);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(userScore.Text);
            temp = temp + 2;
            userScore.Text = temp.ToString();
            questions(temp);
        }

        public void questions(int userScore)
        {
            switch (userScore)
            {

                // head (upper head)
                case 2:
                    Label1.Text = "Do you have high tempreture?";
                    break;
                case 3:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //fever
                    break;
                case 4:
                    Label1.Text = "Is it hard to concentrate?";
                    break;
                case 5:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //concussion 
                    break;

                case 6:
                    Label1.Text = "Do you have pain on one side of the head?";
                    break;
                case 7:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); // Migraine
                    break;
                case 8:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); // Other 
                    break;
                // Mid head

                case 9:
                    Label1.Text = "Are you seeing spots in your vision?";
                    break;
                case 10:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //Diabetic retinopathy
                    break;
                case 11:
                    Label1.Text = "Is it hard to see properly?";
                    break;

                case 13:
                    Label1.Text = "Do you have a runny nose?";
                    break;
                case 12:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //Refractive error
                    break;
                case 14:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //nose bleed
                    break;
                case 15:
                    Label1.Text = "Do you have allergies? ";
                    break;
                case 16:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //
                    break;
                case 17:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //
                    break;

                //Lower head
                case 18:
                    Label1.Text = "Any pain or discomfort in the mouth/teeth/jaw?";
                    break;
                case 19:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); // consult your dentist
                    break;
                case 20:
                    Label1.Text = "Do you have any pain in your ears?";
                    break;
                case 21:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //ear infection
                    break;
                case 22:
                    Label1.Text = "Is there any loss of balance?";
                    break;
                case 23:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);//vertigo
                    break;
                case 24:
                    Label1.Text = "Is there weakness in the foot?";
                    break;
                case 25:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);//spinal stenosis
                    break;
                case 26:
                    Label1.Text = "Is there weakness in the arms?";
                    break;
                case 27:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);//Whiplash
                    break;
                case 28:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);//other
                    break;

                //Upper body

                case 30:
                    Label1.Text = "Do you feel pain in the shoulder joint, stiffness and reduced range of motion in your shoulders? ";
                    break;
                case 31:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);//Arthritis in the shoulder joint
                    break;
                case 32:
                    Label1.Text = "Have you experienced Shoulder Pain, Swelling, Tenderness, Discoloration around the upper arm, Inability to normally move the arm without pain?";
                    break;
                case 33:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 34:
                    Label1.Text = "Have you experienced a visibly deformed or out-of-place shoulder, Swelling or bruising, Intense pain, Inability to move the joint?";
                    break;
                case 35:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 36:
                    Label1.Text = "Do you feel pressure , fullness, burning chest in your back , neck, jaw or arms?";
                    break;
                case 37:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //heart-related chest pain
                    break;
                case 38:
                    Label1.Text = "Have you experienced chest pain or discomfort, which may feel like pressure, burning, tightness?";
                    break;
                case 39:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //heart attack
                    break;
                case 40:
                    Label1.Text = "Do you have Shortness of breath, Abdominal pain, Discomfort in the neck, jaw or back, Stabbing pain?";
                    break;
                case 41:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //Angina
                    break;
                case 42:
                    Label1.Text = "Do you have sudden severe chest or upper back pain, often described as a tearing or ripping sensation, that spreads to the neck or down the back?";
                    break;
                case 43:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //Aortic dissection
                    break;
                case 44:
                    Label1.Text = "Some types of chest pain are associated with injuries and other problems affecting the structures that make up the chest wall, therefore, have you fell recently on your chest?";
                    break;
                case 45:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //Muscle and bone related pain
                    break;
                case 46:
                    Label1.Text = "Have you experienced stiffness and weakness in the affected area, fever, a bite mark difficulty breathing, signs of infection?";
                    break;
                case 47:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //sore muscle
                    break;
                case 48:
                    Label1.Text = "Have you experienced strong pain in your chest area, particularly when you breathe in, swelling or tenderness around the affected ribs?";
                    break;
                case 49:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //injured ribs
                    break;
                case 50:
                    Label1.Text = "The chest pain associated with a collapsed lung typically begins suddenly and can last for hours and is generally associated with  shortness of breath.A collapsed lung occurs when air leaks into the space between the lung and the ribs?";
                    break;
                case 51:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //lung related chest pain
                    break;
                case 52:
                    Label1.Text = "Do have Chest pain on one side especially when taking breaths, Cough, Fast breathing, Fast heart rate, Fatigue?";
                    break;
                case 54:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //Other
                    break;
                case 53:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //Collapsed lung
                    break;
                case 55:
                    Label1.Text = "What part of the region does the pain come from?";
                    break;
                case 56:
                    Label1.Text = "Have you not experienced blood in your urine?";
                    break;
                case 57:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //other
                    break;
                case 58:
                    Label1.Text = "Do you experience any headaches and/or Pain in the back and lower sides?";
                    break;
                case 59:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //Kidney cysts
                    break;
                case 60:
                    Label1.Text = "Do you have a lump in your abdomen?";
                    break;
                case 61:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //other
                    break;
                case 62:
                    Label1.Text = "Do you experience unexplained weight loss and/or loss of appetite ?";
                    break;
                case 63:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //Kidney cancer
                    break;
                case 64:
                    Label1.Text = "Have you not experienced any of the following? Extreme pain in your back or side that is not going away or Fever and chills?";
                    break;
                case 65:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //other
                    break;
                case 66:
                    Label1.Text = "Urine that smells bad or looks cloudy and/or burning feeling when you urinate?";
                    break;
                case 67:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //other
                    break; //kidney stones
                case 68:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //other
                    break; //other
                case 69:
                    Label1.Text = "Have you had one or more of the stated symptoms? Pain that worsens if you cough, walk, or make other jarring movements, Abdominal bloating and/or Flatulence?";
                    break;
                case 70:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //Appendicitis
                    break;
                case 71:
                    Label1.Text = "Have you had one or more of the stated symptoms? swelling of one or more lymph glands such as in the neck or armpits, abnormal sweating, especially at night?";
                    break;
                case 72:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //Lymphoma
                    break;
                case 73:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //other
                    break;
                case 74:
                    Label1.Text = "Have you experienced one or more of the stated symptoms? Discomfort on your right side, just below your ribs Bruising or bleeding easily and/or Vomiting blood?";
                    break;
                case 75:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //acute liver failure
                    break;
                case 76:
                    Label1.Text = "Have you experienced one or more of the stated symptoms? Abdominal swelling, yellow discoloration of your skin and the whites of your eyes (jaundice) And/or White, chalky stools?";
                    break;
                case 77:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //Liver cancer
                    break;
                case 78:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //Other
                    break;
                case 79:
                    Label1.Text = "Have you not experienced any of the following? Difficulty breathing after vomiting and/or Pain when you eat or swallow";
                    break;
                case 80:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //other
                    break;
                case 81:
                    Label1.Text = "Have you experienced large amounts or bloody or dark contents?";
                    break;
                case 82:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //GERD 
                    break;
                case 83:
                    Label1.Text = "Have you experienced any of the stated symptoms? Bloating or a sense of feeling too full or upper abdominal pain or burn or achiness?";
                    break;
                case 84:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //Gastritis
                    break;
                case 85:
                    Label1.Text = "Have you experienced any of the following? Excess hunger and thirst , fatigue, frequent urination.";
                    break;

                case 86:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //Diabetes
                    break;
                case 87:
                    Response.Redirect("Result.aspx?userCounter=" + userScore); //other
                    break;

                // Legs (Joints)

                case 89:
                    Label1.Text = "Does the pain changes (gets better or worse) depending on the weather?";
                    break;
                case 90:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 91:
                    Label1.Text = "Is there a dull pain under the kneecap when exercising?";
                    break;
                case 92:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 93:
                    Label1.Text = "Does the pain occur after sitting for extended periods of time or during activities?";
                    break;
                case 94:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 95:
                    Label1.Text = "Is the pain outside of the knees?";
                    break;
                case 96:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 97:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;

                // Legs (Foot)
                case 98:
                    Label1.Text = "Is the affected area a swollen toe?";
                    break;
                case 99:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 100:
                    Label1.Text = "Is there a bulging bump on the outside of the base of your big toe?";
                    break;
                case 101:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 102:
                    Label1.Text = "Is there a sharp, aching or burning pain in the ball of your foot?";
                    break;
                case 103:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 104:
                    Label1.Text = "Is there pain and stiffness in the joints of the toes?";
                    break;
                case 105:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 106:
                    Label1.Text = "Is there a burning sensation or numbness in the entire foot?";
                    break;
                case 107:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 108:
                    Label1.Text = "Does the pain originate in the heel of the foot?";
                    break;
                case 109:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 110:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;

                // Legs (Calfs)
                case 111:
                    Label1.Text = "Is there ankle or heel pain?";
                    break;
                case 112:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 113:
                    Label1.Text = "Was there an audible pop at the moment of injury?";
                    break;
                case 114:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 115:
                    Label1.Text = "Is there bruising on the affected area?";
                    break;
                case 116:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 117:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;

                // Legs (Thighs)
                case 118:
                    Label1.Text = "Is there a swelling around the quad tendon?";
                    break;
                case 119:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 120:
                    Label1.Text = "Do you feel tingling, pins and needles sensations?";
                    break;
                case 121:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 122:
                    Label1.Text = "Is there a burning pain in the affected area?";
                    break;
                case 123:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 124:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;

                // Arms (Elbow)  
                case 126:
                    Label1.Text = "Did you fall recently or hit your elbow hard?";
                    break;
                case 127:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 128:
                    Label1.Text = "Do you overuse your elbow? For example: playing sports or at work.";
                    break;
                case 129:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 130:
                    Label1.Text = "Do you feel pain, swelling, and stiffness in you elbow?";
                    break;
                case 131:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 132:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;

                // Arms (Hand)
                case 133:
                    Label1.Text = "Does it hurt to make a fist, grasp, or hold objects, turn ur wrist?";
                    break;
                case 134:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 135:
                    Label1.Text = "Do you feel tingling or numbness in your fingers?";
                    break;
                case 136:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 137:
                    Label1.Text = "Do you not feel extreme pain with swelling and stiffness?";
                    break;
                case 138:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 139:
                    Label1.Text = "Did you hit your finger with blunt object?";
                    break;
                case 140:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 141:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;

                // Arms (Forearm)

                case 142:
                    Label1.Text = "Did you overuse your forearms? For example: playing sports like tennis OR using computers a lot.";
                    break;
                case 143:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 144:
                    Label1.Text = " Do you feel extreme pain with swelling and stiffness?";
                    break;
                case 145:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 146:
                    Label1.Text = "Do you feel extreme pain with swelling and stiffness?";
                    break;
                case 147:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 148:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;

                // Arms (Upperarm)

                case 149:
                    Label1.Text = "Did you excercise your arms recently?";
                    break;
                case 150:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 151:
                    Label1.Text = "Do you feel numbness, burning and loss of sensation in your upper arm?";
                    break;
                case 152:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 153:
                    Label1.Text = "Do you have reduced range of motion in the joint, swelling, pain, redness and tenderness in the joint?";
                    break;
                case 154:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 155:
                    Label1.Text = "Do you feel pain in one of your arms with shortness of breath and chest pain?";
                    break;
                case 156:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;
                case 157:
                    Response.Redirect("Result.aspx?userCounter=" + userScore);
                    break;



            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(TextBox1.Text);
            userScore.Text = temp.ToString();
            questions(temp);
        }
    }

}