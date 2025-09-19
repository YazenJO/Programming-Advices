using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Tree_Implementation_in_C_
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T value)
        {
            this.Value = value;
            Children = new List<TreeNode<T>>();
        }
        public void AddChild(TreeNode<T> node) { Children.Add(node); }
    }
    
    public class Tree<T>
    {
        public TreeNode<T> Root { get; private set; }

        public Tree(T root) { Root = new TreeNode<T>(root); }

        public bool Find(TreeNode<T> node, T value)
        {
            if (node.Value.Equals(value)) return true;
            foreach (var child in node.Children)
            {
                if (Find(child, value)) return true;
            }
            return false;
        }
    }
    
    internal class Program
    {
        // Company hierarchy tree
        static Tree<string> CompanyOwner;
        
        static void Main(string[] args)
        {
            // Build the company hierarchy
            BuildCompanyHierarchy();
            
            Console.WriteLine("=== TechCorp Company Hierarchy ===");
            Console.WriteLine("Total Employees: 20\n");
            
            Program p = new Program();
            p.PrintTree(CompanyOwner.Root); 

            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        
        static void BuildCompanyHierarchy()
        {
            // Create the company tree with CEO as root
            CompanyOwner = new Tree<string>("CEO - Tareq Abusharkh");
            
            // Level 1: Vice Presidents (3 VPs)
            var vpEngineering = new TreeNode<string>("VP Engineering - Yazan Abusharkh");
            var vpSales = new TreeNode<string>("VP Sales - Layla Hassan");
            var vpHR = new TreeNode<string>("VP Human Resources - Khalid Al-Mansouri");
            
            CompanyOwner.Root.AddChild(vpEngineering);
            CompanyOwner.Root.AddChild(vpSales);
            CompanyOwner.Root.AddChild(vpHR);
            
            // Level 2: Directors and Senior Managers (4 people under VPs)
            var directorDev = new TreeNode<string>("Director Development - Tariq Al-Kindi");
            var directorQA = new TreeNode<string>("Director QA - Fatima Al-Balushi");
            var salesManagerEast = new TreeNode<string>("Sales Manager East - Youssef Al-Najjar");
            var hrManager = new TreeNode<string>("HR Manager - Mariam Al-Qasimi");
            
            vpEngineering.AddChild(directorDev);
            vpEngineering.AddChild(directorQA);
            vpSales.AddChild(salesManagerEast);
            vpHR.AddChild(hrManager);
            
            // Level 3: Team Leaders and Senior Staff (6 people)
            var teamLeadFrontend = new TreeNode<string>("Team Lead Frontend - Ahmed Al-Farisi");
            var teamLeadBackend = new TreeNode<string>("Team Lead Backend - Nour Al-Din");
            var seniorQA = new TreeNode<string>("Senior QA Engineer - Hassan Al-Maktoum");
            var salesRepSenior = new TreeNode<string>("Senior Sales Rep - Yasmin Al-Hashemi");
            var salesRepJunior = new TreeNode<string>("Sales Representative - Saeed Al-Bloushi");
            var hrSpecialist = new TreeNode<string>("HR Specialist - Huda Al-Zaabi");
            
            directorDev.AddChild(teamLeadFrontend);
            directorDev.AddChild(teamLeadBackend);
            directorQA.AddChild(seniorQA);
            salesManagerEast.AddChild(salesRepSenior);
            salesManagerEast.AddChild(salesRepJunior);
            hrManager.AddChild(hrSpecialist);
            
            // Level 4: Individual Contributors (6 people)
            var frontendDev1 = new TreeNode<string>("Frontend Developer - Zain Al-Rashid");
            var frontendDev2 = new TreeNode<string>("Frontend Developer - Salma Al-Khoury");
            var backendDev1 = new TreeNode<string>("Backend Developer - Majid Al-Shamsi");
            var backendDev2 = new TreeNode<string>("Backend Developer - Rana Al-Otaibi");
            var qaEngineer1 = new TreeNode<string>("QA Engineer - Faisal Al-Muhairi");
            var qaEngineer2 = new TreeNode<string>("QA Engineer - Leena Al-Subaihi");
            
            teamLeadFrontend.AddChild(frontendDev1);
            teamLeadFrontend.AddChild(frontendDev2);
            teamLeadBackend.AddChild(backendDev1);
            teamLeadBackend.AddChild(backendDev2);
            seniorQA.AddChild(qaEngineer1);
            seniorQA.AddChild(qaEngineer2);

        }


        public void PrintTree(TreeNode<string> root, string indent = "", bool isLast = true)
        {
            Console.WriteLine(indent + "+- " + root.Value);
            indent += isLast ? "   " : "|  ";
            for (int i = 0; i < root.Children.Count; i++)
            {
                PrintTree(root.Children[i], indent, i == root.Children.Count - 1);
            }
        }
    }
}
