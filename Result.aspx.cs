using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String score = Request["userCounter"].ToString();
            switch (int.Parse(score))
            {
                // Head
                case 3:
                    Label1.Text = "Fever";
                    break;
                case 5:
                    Label1.Text = "Concussion";
                    break;
                case 7:
                    Label1.Text = "Migraine";
                    break;
                case 8:
                    Label1.Text = "An uncommon Condintion";
                    break;
                case 10:
                    Label1.Text = "Diabetic Retinopathy";
                    break;
                case 12:
                    Label1.Text = "Refractive Error";
                    break;
                case 14:
                    Label1.Text = "Nose Bleed";
                    break;
                case 17:
                    Label1.Text = "Deviated Septum";
                    break;
                case 16:
                    Label1.Text = "Allergic Rthinitis";
                    break;
                case 19:
                    Label1.Text = "An Uncommon Condintion";
                    break;
                case 21:
                    Label1.Text = " Ear Infection";
                    break;
                case 23:
                    Label1.Text = "Vertigo";
                    break;
                case 25:
                    Label1.Text = "Spinal Stenosis";
                    break;
                case 27:
                    Label1.Text = "Whiplash";
                    break;
                case 28:
                    Label1.Text = "An Uncommon Condintion";
                    break;

                // Upper Body
                case 31:
                    Label1.Text = "Arthritis in The Shoulder Joint";
                    break;
                case 33:
                    Label1.Text = "Fracture/Broken Shoulder Bone.";
                    break;
                case 35:
                    Label1.Text = "Dislocation of The Shoulder";
                    break;
                case 36:
                    Label1.Text = "An Uncommon Condintion";
                    break;
                case 37:
                    Label1.Text = "Heart-related Chest Pain";
                    break;
                case 39:
                    Label1.Text = "Heart Attack";
                    break;
                case 41:
                    Label1.Text = "Angina";
                    break;
                case 43:
                    Label1.Text = "Aortic Dissection";
                    break;
                case 45:
                    Label1.Text = "Muscle And Bone Related Pain";
                    break;
                case 47:
                    Label1.Text = "Sore Muscle";
                    break;
                case 49:
                    Label1.Text = "Injured Ribs ";
                    break;
                case 51:
                    Label1.Text = "Lung-related Chest Pain";
                    break;
                case 53:
                    Label1.Text = "Collapsed Lung";
                    break;
                case 54:
                    Label1.Text = "An Uncommon Condintion";
                    break;

                // Lower Body
                case 57:
                    Label1.Text = "An Uncommon Condintion";
                    break;
                case 59:
                    Label1.Text = "Kidney Cysts";
                    break;
                case 61:
                    Label1.Text = "An Uncommon Condintion";
                    break;
                case 63:
                    Label1.Text = "Kidney Cancer";
                    break;
                case 65:
                    Label1.Text = "An Uncommon Condintion";
                    break;
                case 67:
                    Label1.Text = "Kidney Stones";
                    break;
                case 68:
                    Label1.Text = "An Uncommon Condintion";
                    break;
                case 70:
                    Label1.Text = "Appendicitis";
                    break;
                case 72:
                    Label1.Text = "Lymphoma";
                    break;
                case 73:
                    Label1.Text = "An Uncommon Condintion";
                    break;
                case 75:
                    Label1.Text = "Acute Liver Failure";
                    break;
                case 77:
                    Label1.Text = "Liver Cancer";
                    break;
                case 78:
                    Label1.Text = "An Uncommon Condintion";
                    break;
                case 80:
                    Label1.Text = "An Uncommon Condintion";
                    break;
                case 82:
                    Label1.Text = "GERD (Gastroesophageal Reflux Disease)";
                    break;
                case 84:
                    Label1.Text = "Gastritis";
                    break;
                case 86:
                    Label1.Text = "Diabetes";
                    break;
                case 87:
                    Label1.Text = "An Uncommon Condintion";
                    break;

                // Arms
                case 127:
                    Label1.Text = "Dislocated Elbow";
                    break;
                case 129:
                    Label1.Text = "Bursitis";
                    break;
                case 131:
                    Label1.Text = "Fracture";
                    break;
                case 132:
                    Label1.Text = "An Uncommon Condintion";
                    break;
                case 134:
                    Label1.Text = " De Quervain's Tendinitis";
                    break;
                case 136:
                    Label1.Text = "An Uncommon Condintion";
                    break;
                case 138:
                    Label1.Text = "An Uncommon Condintion";
                    break;
                case 140:
                    Label1.Text = "Fracture";
                    break;
                case 141:
                    Label1.Text = "Arthritis";
                    break;
                case 143:
                    Label1.Text = "Repetitive Strain Injury";
                    break;
                case 145:
                    Label1.Text = "An Uncommon Ucondintion";
                    break;
                case 147:
                    Label1.Text = "Angina";
                    break;
                case 148:
                    Label1.Text = "An Uncommon Condintion";
                    break;
                case 150:
                    Label1.Text = "Sore Arms";
                    break;
                case 152:
                    Label1.Text = "Pinched Nerves";
                    break;
                case 154:
                    Label1.Text = "Arm Sprain";
                    break;
                case 156:
                    Label1.Text = "Heart Attack";
                    break;
                case 157:
                    Label1.Text = "An Uncommon Condintion";
                    break;
                //Legs
                case 90:
                    Label1.Text = "Knee Arthritis";
                    break;
                case 92:
                    Label1.Text = "Torn Knee Cartilage";
                    break;
                case 94:
                    Label1.Text = "Patellofemoral Pain Syndrome";
                    break;
                case 96:
                    Label1.Text = "Iliotibial Band Syndrome";
                    break;
                case 97:
                    Label1.Text = "An Uncommon Condition";
                    break;
                case 99:
                    Label1.Text = "Ingrown Toenails";
                    break;
                case 101:
                    Label1.Text = "Bunions";
                    break;
                case 103:
                    Label1.Text = "Metatarsalgia";
                    break;
                case 105:
                    Label1.Text = "Osteoarthritis";
                    break;
                case 107:
                    Label1.Text = "Tarsal Tunnel Syndrome";
                    break;
                case 109:
                    Label1.Text = "Plantar Fasciitis";
                    break;
                case 110:
                    Label1.Text = "An Uncommon Condition";
                    break;
                case 112:
                    Label1.Text = "Achilles Tendonitis";
                    break;
                case 114:
                    Label1.Text = "Medial Gastrocnemius Strain";
                    break;
                case 116:
                    Label1.Text = "Plantaris Muscle Rupture";
                    break;
                case 117:
                    Label1.Text = "An Uncommon Condition";
                    break;
                case 119:
                    Label1.Text = "Quadriceps Tendonitis";
                    break;
                case 121:
                    Label1.Text = "Spinal Stenosis";
                    break;
                case 123:
                    Label1.Text = "Pinched Spinal Nerve";
                    break;
                case 124:
                    Label1.Text = "An Uncommon Condition";
                    break;
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}