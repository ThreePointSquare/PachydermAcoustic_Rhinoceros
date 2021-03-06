//'Pachyderm-Acoustic: Geometrical Acoustics for Rhinoceros (GPL) by Arthur van der Harten 
//' 
//'This file is part of Pachyderm-Acoustic. 
//' 
//'Copyright (c) 2008-2019, Arthur van der Harten 
//'Pachyderm-Acoustic is free software; you can redistribute it and/or modify 
//'it under the terms of the GNU General Public License as published 
//'by the Free Software Foundation; either version 3 of the License, or 
//'(at your option) any later version. 
//'Pachyderm-Acoustic is distributed in the hope that it will be useful, 
//'but WITHOUT ANY WARRANTY; without even the implied warranty of 
//'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the 
//'GNU General Public License for more details. 
//' 
//'You should have received a copy of the GNU General Public 
//'License along with Pachyderm-Acoustic; if not, write to the Free Software 
//'Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA. 

namespace Pachyderm_Acoustic
{
    namespace UI
    {
        partial class Pach_Hybrid_Control : System.Windows.Forms.UserControl
        {

            //UserControl overrides dispose to clean up the component list. 
            [System.Diagnostics.DebuggerNonUserCode()]
            protected override void Dispose(bool disposing)
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            //Required by the Windows Form Designer 
            private System.ComponentModel.IContainer components = null;

            //NOTE: The following procedure is required by the Windows Form Designer 
            //It can be modified using the Windows Form Designer. 
            //Do not modify it using the code editor. 
            [System.Diagnostics.DebuggerStepThrough()]
            private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel13 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel14 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel15 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel16 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel17 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel18 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel19 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel20 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel21 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel22 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel23 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel24 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Delete_Material = new System.Windows.Forms.Button();
            this.Save_Material = new System.Windows.Forms.Button();
            this.Material_Name = new System.Windows.Forms.MaskedTextBox();
            this.Abs_Designer = new System.Windows.Forms.Button();
            this.Abs4kOut = new System.Windows.Forms.NumericUpDown();
            this.Material_Lib = new System.Windows.Forms.ListBox();
            this.Mat_Lbl = new System.Windows.Forms.Label();
            this.Abs8kOut = new System.Windows.Forms.NumericUpDown();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Abs2kOut = new System.Windows.Forms.NumericUpDown();
            this.Abs1kOut = new System.Windows.Forms.NumericUpDown();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Abs500Out = new System.Windows.Forms.NumericUpDown();
            this.Abs250Out = new System.Windows.Forms.NumericUpDown();
            this.Abs125Out = new System.Windows.Forms.NumericUpDown();
            this.Abs63Out = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.Abs63 = new System.Windows.Forms.TrackBar();
            this.Abs125 = new System.Windows.Forms.TrackBar();
            this.Abs250 = new System.Windows.Forms.TrackBar();
            this.Abs500 = new System.Windows.Forms.TrackBar();
            this.Abs1k = new System.Windows.Forms.TrackBar();
            this.Abs2k = new System.Windows.Forms.TrackBar();
            this.Abs4k = new System.Windows.Forms.TrackBar();
            this.Abs8k = new System.Windows.Forms.TrackBar();
            this.AbsFlat = new System.Windows.Forms.TrackBar();
            this.ScatFlat = new System.Windows.Forms.TrackBar();
            this.Scat8kOut = new System.Windows.Forms.NumericUpDown();
            this.Scat8kv = new System.Windows.Forms.TrackBar();
            this.Scat4kv = new System.Windows.Forms.TrackBar();
            this.Scat4kOut = new System.Windows.Forms.NumericUpDown();
            this.Scat2kOut = new System.Windows.Forms.NumericUpDown();
            this.Scat2kv = new System.Windows.Forms.TrackBar();
            this.Scat1kv = new System.Windows.Forms.TrackBar();
            this.Scat1kOut = new System.Windows.Forms.NumericUpDown();
            this.Scat500Out = new System.Windows.Forms.NumericUpDown();
            this.Scat500v = new System.Windows.Forms.TrackBar();
            this.Scat250v = new System.Windows.Forms.TrackBar();
            this.Scat250Out = new System.Windows.Forms.NumericUpDown();
            this.Scat125Out = new System.Windows.Forms.NumericUpDown();
            this.Scat125v = new System.Windows.Forms.TrackBar();
            this.Scat63v = new System.Windows.Forms.TrackBar();
            this.Scat63Out = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.SmartMat_Display = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Calculate = new System.Windows.Forms.Button();
            this.RTBox = new System.Windows.Forms.CheckBox();
            this.ISBox = new System.Windows.Forms.CheckBox();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.EdgeFreq = new System.Windows.Forms.CheckBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.Atten_Method = new System.Windows.Forms.ComboBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.Air_Pressure = new System.Windows.Forms.NumericUpDown();
            this.Label3 = new System.Windows.Forms.Label();
            this.Rel_Humidity = new System.Windows.Forms.NumericUpDown();
            this.AirTemp = new System.Windows.Forms.Label();
            this.Air_Temp = new System.Windows.Forms.NumericUpDown();
            this.CO_TIME = new System.Windows.Forms.NumericUpDown();
            this.Spec_Rays = new System.Windows.Forms.RadioButton();
            this.ReceiverSelection = new System.Windows.Forms.ComboBox();
            this.RT_Count = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.Spec_RayCount = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.Image_Order = new System.Windows.Forms.NumericUpDown();
            this.DetailedConvergence = new System.Windows.Forms.RadioButton();
            this.Minimum_Convergence = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.BTM_ED = new System.Windows.Forms.CheckBox();
            this.Specular_Trace = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.COTime = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LayerLbl = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Absorption = new System.Windows.Forms.TabPage();
            this.Scattering = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.quart_lambda = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.user_quart_lambda = new System.Windows.Forms.TrackBar();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.PlasterScatter = new System.Windows.Forms.Button();
            this.GlassScatter = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.Transparency = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.Trans_Flat = new System.Windows.Forms.TrackBar();
            this.Trans_8k_Out = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.Trans_8kv = new System.Windows.Forms.TrackBar();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.Trans_4k_Out = new System.Windows.Forms.NumericUpDown();
            this.Trans_4kv = new System.Windows.Forms.TrackBar();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.Trans_2k_Out = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.Trans_2kv = new System.Windows.Forms.TrackBar();
            this.label36 = new System.Windows.Forms.Label();
            this.Trans_63v = new System.Windows.Forms.TrackBar();
            this.Trans_63_Out = new System.Windows.Forms.NumericUpDown();
            this.Trans_1k_Out = new System.Windows.Forms.NumericUpDown();
            this.Trans_1kv = new System.Windows.Forms.TrackBar();
            this.Trans_125_Out = new System.Windows.Forms.NumericUpDown();
            this.Trans_125v = new System.Windows.Forms.TrackBar();
            this.Trans_500_Out = new System.Windows.Forms.NumericUpDown();
            this.Trans_250v = new System.Windows.Forms.TrackBar();
            this.Trans_500v = new System.Windows.Forms.TrackBar();
            this.Trans_250_Out = new System.Windows.Forms.NumericUpDown();
            this.Trans_Check = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.Isolation_Lib = new System.Windows.Forms.ListBox();
            this.label63 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteAssembly = new System.Windows.Forms.Button();
            this.SaveAssembly = new System.Windows.Forms.Button();
            this.IsolationAssemblies = new System.Windows.Forms.MaskedTextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.TL_Check = new System.Windows.Forms.CheckBox();
            this.TL8k = new System.Windows.Forms.NumericUpDown();
            this.label54 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.TL4k = new System.Windows.Forms.NumericUpDown();
            this.TL2k = new System.Windows.Forms.NumericUpDown();
            this.TL1k = new System.Windows.Forms.NumericUpDown();
            this.TL500 = new System.Windows.Forms.NumericUpDown();
            this.TL250 = new System.Windows.Forms.NumericUpDown();
            this.TL125 = new System.Windows.Forms.NumericUpDown();
            this.TL63 = new System.Windows.Forms.NumericUpDown();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.LayerDisplay = new System.Windows.Forms.ComboBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.SourceList = new System.Windows.Forms.CheckedListBox();
            this.SourceContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PowerMod = new System.Windows.Forms.ToolStripMenuItem();
            this.DelayMod = new System.Windows.Forms.ToolStripMenuItem();
            this.Source_Aim = new System.Windows.Forms.ComboBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SRT8 = new System.Windows.Forms.Label();
            this.Parameter_Choice = new System.Windows.Forms.ComboBox();
            this.SRT7 = new System.Windows.Forms.Label();
            this.SRT6 = new System.Windows.Forms.Label();
            this.SRT2 = new System.Windows.Forms.Label();
            this.SRT5 = new System.Windows.Forms.Label();
            this.SRT3 = new System.Windows.Forms.Label();
            this.SRT4 = new System.Windows.Forms.Label();
            this.SRT1 = new System.Windows.Forms.Label();
            this.ISOCOMP = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.Receiver_Choice = new System.Windows.Forms.ComboBox();
            this.Analysis_View = new ZedGraph.ZedGraphControl();
            this.label26 = new System.Windows.Forms.Label();
            this.Normalize_Graph = new System.Windows.Forms.CheckBox();
            this.Alt_Choice = new System.Windows.Forms.NumericUpDown();
            this.LockUserScale = new System.Windows.Forms.CheckBox();
            this.Azi_Choice = new System.Windows.Forms.NumericUpDown();
            this.Graph_Type = new System.Windows.Forms.ComboBox();
            this.Auralisation = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Graph_Octave = new System.Windows.Forms.ComboBox();
            this.IS_Path_Box = new System.Windows.Forms.CheckedListBox();
            this.PathContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.PathCount = new System.Windows.Forms.Label();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FromMeshSphereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FromPointInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DirectionalSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectSourceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectASphereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FromSphereObjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FromPointInputToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.SP_menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveParameterResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePTBFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveVRSpectraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label64 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Abs4kOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs8kOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs2kOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs1kOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs500Out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs250Out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs125Out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs63Out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs125)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs250)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs1k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs2k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs4k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs8k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbsFlat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScatFlat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat8kOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat8kv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat4kv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat4kOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat2kOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat2kv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat1kv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat1kOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat500Out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat500v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat250v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat250Out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat125Out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat125v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat63v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat63Out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmartMat_Display)).BeginInit();
            this.Tabs.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Air_Pressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rel_Humidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Air_Temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CO_TIME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RT_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spec_RayCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Order)).BeginInit();
            this.TabPage4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Absorption.SuspendLayout();
            this.Scattering.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_quart_lambda)).BeginInit();
            this.Transparency.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_Flat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_8k_Out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_8kv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_4k_Out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_4kv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_2k_Out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_2kv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_63v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_63_Out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_1k_Out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_1kv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_125_Out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_125v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_500_Out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_250v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_500v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_250_Out)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TL8k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL4k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL2k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL1k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL500)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL250)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL125)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL63)).BeginInit();
            this.TabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SourceContext.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Alt_Choice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Azi_Choice)).BeginInit();
            this.PathContext.SuspendLayout();
            this.SP_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel4.Controls.Add(this.label24, 0, 12);
            this.tableLayoutPanel4.Controls.Add(this.groupBox5, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.Abs_Designer, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.Abs4kOut, 3, 10);
            this.tableLayoutPanel4.Controls.Add(this.Material_Lib, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.Mat_Lbl, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Abs8kOut, 3, 11);
            this.tableLayoutPanel4.Controls.Add(this.Label8, 0, 11);
            this.tableLayoutPanel4.Controls.Add(this.Label6, 0, 10);
            this.tableLayoutPanel4.Controls.Add(this.Label9, 0, 9);
            this.tableLayoutPanel4.Controls.Add(this.Abs2kOut, 3, 9);
            this.tableLayoutPanel4.Controls.Add(this.Abs1kOut, 3, 8);
            this.tableLayoutPanel4.Controls.Add(this.Label10, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.Label11, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.Label7, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.Label12, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.Label13, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.Abs500Out, 3, 7);
            this.tableLayoutPanel4.Controls.Add(this.Abs250Out, 3, 6);
            this.tableLayoutPanel4.Controls.Add(this.Abs125Out, 3, 5);
            this.tableLayoutPanel4.Controls.Add(this.Abs63Out, 3, 4);
            this.tableLayoutPanel4.Controls.Add(this.label18, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.Abs63, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.Abs125, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.Abs250, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.Abs500, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.Abs1k, 1, 8);
            this.tableLayoutPanel4.Controls.Add(this.Abs2k, 1, 9);
            this.tableLayoutPanel4.Controls.Add(this.Abs4k, 1, 10);
            this.tableLayoutPanel4.Controls.Add(this.Abs8k, 1, 11);
            this.tableLayoutPanel4.Controls.Add(this.AbsFlat, 1, 12);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 14;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(493, 619);
            this.tableLayoutPanel4.TabIndex = 29;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(4, 486);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 31);
            this.label24.TabIndex = 38;
            this.label24.Text = "Flatten All";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.groupBox5, 3);
            this.groupBox5.Controls.Add(this.Delete_Material);
            this.groupBox5.Controls.Add(this.Save_Material);
            this.groupBox5.Controls.Add(this.Material_Name);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(270, 4);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.SetRowSpan(this.groupBox5, 2);
            this.groupBox5.Size = new System.Drawing.Size(219, 177);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Save Material Absorption";
            // 
            // Delete_Material
            // 
            this.Delete_Material.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_Material.Location = new System.Drawing.Point(8, 90);
            this.Delete_Material.Margin = new System.Windows.Forms.Padding(4);
            this.Delete_Material.Name = "Delete_Material";
            this.Delete_Material.Size = new System.Drawing.Size(203, 28);
            this.Delete_Material.TabIndex = 2;
            this.Delete_Material.Text = "Delete Materials";
            this.Delete_Material.UseVisualStyleBackColor = true;
            this.Delete_Material.Click += new System.EventHandler(this.Delete_Material_Click);
            // 
            // Save_Material
            // 
            this.Save_Material.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Material.Location = new System.Drawing.Point(8, 54);
            this.Save_Material.Margin = new System.Windows.Forms.Padding(4);
            this.Save_Material.Name = "Save_Material";
            this.Save_Material.Size = new System.Drawing.Size(203, 28);
            this.Save_Material.TabIndex = 1;
            this.Save_Material.Text = "Save Material";
            this.Save_Material.UseVisualStyleBackColor = true;
            this.Save_Material.Click += new System.EventHandler(this.SaveAbs_Click);
            // 
            // Material_Name
            // 
            this.Material_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Material_Name.Location = new System.Drawing.Point(8, 22);
            this.Material_Name.Margin = new System.Windows.Forms.Padding(4);
            this.Material_Name.Name = "Material_Name";
            this.Material_Name.Size = new System.Drawing.Size(202, 22);
            this.Material_Name.TabIndex = 0;
            // 
            // Abs_Designer
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.Abs_Designer, 5);
            this.Abs_Designer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Abs_Designer.Location = new System.Drawing.Point(4, 189);
            this.Abs_Designer.Margin = new System.Windows.Forms.Padding(4);
            this.Abs_Designer.Name = "Abs_Designer";
            this.Abs_Designer.Size = new System.Drawing.Size(485, 27);
            this.Abs_Designer.TabIndex = 2;
            this.Abs_Designer.Text = "Call Absorption Designer";
            this.Abs_Designer.UseVisualStyleBackColor = true;
            this.Abs_Designer.Click += new System.EventHandler(this.Abs_Designer_Click);
            // 
            // Abs4kOut
            // 
            this.Abs4kOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abs4kOut.AutoSize = true;
            this.Abs4kOut.Location = new System.Drawing.Point(403, 428);
            this.Abs4kOut.Margin = new System.Windows.Forms.Padding(4);
            this.Abs4kOut.Name = "Abs4kOut";
            this.Abs4kOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Abs4kOut.Size = new System.Drawing.Size(72, 22);
            this.Abs4kOut.TabIndex = 32;
            this.Abs4kOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Abs4kOut.ValueChanged += new System.EventHandler(this.Abs4kOut_ValueChanged);
            // 
            // Material_Lib
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.Material_Lib, 2);
            this.Material_Lib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Material_Lib.FormattingEnabled = true;
            this.Material_Lib.ItemHeight = 16;
            this.Material_Lib.Location = new System.Drawing.Point(4, 26);
            this.Material_Lib.Margin = new System.Windows.Forms.Padding(4);
            this.Material_Lib.Name = "Material_Lib";
            this.Material_Lib.ScrollAlwaysVisible = true;
            this.Material_Lib.Size = new System.Drawing.Size(258, 155);
            this.Material_Lib.TabIndex = 8;
            this.Material_Lib.SelectedIndexChanged += new System.EventHandler(this.Material_Lib_SelectedIndexChanged);
            // 
            // Mat_Lbl
            // 
            this.Mat_Lbl.AutoSize = true;
            this.Mat_Lbl.Location = new System.Drawing.Point(4, 0);
            this.Mat_Lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mat_Lbl.Name = "Mat_Lbl";
            this.Mat_Lbl.Size = new System.Drawing.Size(110, 17);
            this.Mat_Lbl.TabIndex = 7;
            this.Mat_Lbl.Text = "Material Library:";
            // 
            // Abs8kOut
            // 
            this.Abs8kOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abs8kOut.AutoSize = true;
            this.Abs8kOut.Location = new System.Drawing.Point(403, 459);
            this.Abs8kOut.Margin = new System.Windows.Forms.Padding(4);
            this.Abs8kOut.Name = "Abs8kOut";
            this.Abs8kOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Abs8kOut.Size = new System.Drawing.Size(72, 22);
            this.Abs8kOut.TabIndex = 33;
            this.Abs8kOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Abs8kOut.ValueChanged += new System.EventHandler(this.Abs8kOut_ValueChanged);
            // 
            // Label8
            // 
            this.Label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(4, 455);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(44, 31);
            this.Label8.TabIndex = 24;
            this.Label8.Text = "8 kHz";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label6
            // 
            this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(4, 424);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(44, 31);
            this.Label6.TabIndex = 22;
            this.Label6.Text = "4 kHz";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label9
            // 
            this.Label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(4, 393);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(44, 31);
            this.Label9.TabIndex = 21;
            this.Label9.Text = "2 kHz";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Abs2kOut
            // 
            this.Abs2kOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abs2kOut.AutoSize = true;
            this.Abs2kOut.Location = new System.Drawing.Point(403, 397);
            this.Abs2kOut.Margin = new System.Windows.Forms.Padding(4);
            this.Abs2kOut.Name = "Abs2kOut";
            this.Abs2kOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Abs2kOut.Size = new System.Drawing.Size(72, 22);
            this.Abs2kOut.TabIndex = 31;
            this.Abs2kOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Abs2kOut.ValueChanged += new System.EventHandler(this.Abs2kOut_ValueChanged);
            // 
            // Abs1kOut
            // 
            this.Abs1kOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abs1kOut.AutoSize = true;
            this.Abs1kOut.Location = new System.Drawing.Point(403, 366);
            this.Abs1kOut.Margin = new System.Windows.Forms.Padding(4);
            this.Abs1kOut.Name = "Abs1kOut";
            this.Abs1kOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Abs1kOut.Size = new System.Drawing.Size(72, 22);
            this.Abs1kOut.TabIndex = 30;
            this.Abs1kOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Abs1kOut.ValueChanged += new System.EventHandler(this.Abs1kOut_ValueChanged);
            // 
            // Label10
            // 
            this.Label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(4, 362);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(44, 31);
            this.Label10.TabIndex = 20;
            this.Label10.Text = "1 kHz";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label11
            // 
            this.Label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(4, 331);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(53, 31);
            this.Label11.TabIndex = 19;
            this.Label11.Text = "500 Hz";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(4, 300);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(53, 31);
            this.Label7.TabIndex = 25;
            this.Label7.Text = "250 Hz";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label12
            // 
            this.Label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(4, 269);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(53, 31);
            this.Label12.TabIndex = 18;
            this.Label12.Text = "125 Hz";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label13
            // 
            this.Label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(4, 238);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(57, 31);
            this.Label13.TabIndex = 17;
            this.Label13.Text = "62.5 Hz";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Abs500Out
            // 
            this.Abs500Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abs500Out.AutoSize = true;
            this.Abs500Out.Location = new System.Drawing.Point(403, 335);
            this.Abs500Out.Margin = new System.Windows.Forms.Padding(4);
            this.Abs500Out.Name = "Abs500Out";
            this.Abs500Out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Abs500Out.Size = new System.Drawing.Size(72, 22);
            this.Abs500Out.TabIndex = 29;
            this.Abs500Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Abs500Out.ValueChanged += new System.EventHandler(this.Abs500Out_ValueChanged);
            // 
            // Abs250Out
            // 
            this.Abs250Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abs250Out.AutoSize = true;
            this.Abs250Out.Location = new System.Drawing.Point(403, 304);
            this.Abs250Out.Margin = new System.Windows.Forms.Padding(4);
            this.Abs250Out.Name = "Abs250Out";
            this.Abs250Out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Abs250Out.Size = new System.Drawing.Size(72, 22);
            this.Abs250Out.TabIndex = 28;
            this.Abs250Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Abs250Out.ValueChanged += new System.EventHandler(this.Abs250Out_ValueChanged);
            // 
            // Abs125Out
            // 
            this.Abs125Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abs125Out.AutoSize = true;
            this.Abs125Out.Location = new System.Drawing.Point(403, 273);
            this.Abs125Out.Margin = new System.Windows.Forms.Padding(4);
            this.Abs125Out.Name = "Abs125Out";
            this.Abs125Out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Abs125Out.Size = new System.Drawing.Size(72, 22);
            this.Abs125Out.TabIndex = 27;
            this.Abs125Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Abs125Out.ValueChanged += new System.EventHandler(this.Abs125Out_ValueChanged);
            // 
            // Abs63Out
            // 
            this.Abs63Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abs63Out.AutoSize = true;
            this.Abs63Out.Location = new System.Drawing.Point(403, 242);
            this.Abs63Out.Margin = new System.Windows.Forms.Padding(4);
            this.Abs63Out.Name = "Abs63Out";
            this.Abs63Out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Abs63Out.Size = new System.Drawing.Size(72, 22);
            this.Abs63Out.TabIndex = 26;
            this.Abs63Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Abs63Out.ValueChanged += new System.EventHandler(this.Abs63Out_ValueChanged);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label18, 3);
            this.label18.Location = new System.Drawing.Point(4, 221);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(291, 17);
            this.label18.TabIndex = 40;
            this.label18.Text = "Absorption Coefficients (% energy absorbed)";
            // 
            // Abs63
            // 
            this.Abs63.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abs63.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel4.SetColumnSpan(this.Abs63, 2);
            this.Abs63.LargeChange = 10;
            this.Abs63.Location = new System.Drawing.Point(137, 242);
            this.Abs63.Margin = new System.Windows.Forms.Padding(4);
            this.Abs63.Maximum = 100;
            this.Abs63.Name = "Abs63";
            this.Abs63.Size = new System.Drawing.Size(258, 23);
            this.Abs63.TabIndex = 16;
            this.Abs63.TickFrequency = 10;
            this.Abs63.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Abs63.Value = 1;
            this.Abs63.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Abs125
            // 
            this.Abs125.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abs125.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel4.SetColumnSpan(this.Abs125, 2);
            this.Abs125.LargeChange = 10;
            this.Abs125.Location = new System.Drawing.Point(137, 273);
            this.Abs125.Margin = new System.Windows.Forms.Padding(4);
            this.Abs125.Maximum = 100;
            this.Abs125.Name = "Abs125";
            this.Abs125.Size = new System.Drawing.Size(258, 23);
            this.Abs125.TabIndex = 15;
            this.Abs125.TickFrequency = 10;
            this.Abs125.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Abs125.Value = 1;
            this.Abs125.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Abs250
            // 
            this.Abs250.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abs250.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel4.SetColumnSpan(this.Abs250, 2);
            this.Abs250.LargeChange = 10;
            this.Abs250.Location = new System.Drawing.Point(137, 304);
            this.Abs250.Margin = new System.Windows.Forms.Padding(4);
            this.Abs250.Maximum = 100;
            this.Abs250.Name = "Abs250";
            this.Abs250.Size = new System.Drawing.Size(258, 23);
            this.Abs250.TabIndex = 9;
            this.Abs250.TickFrequency = 10;
            this.Abs250.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Abs250.Value = 1;
            this.Abs250.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Abs500
            // 
            this.Abs500.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abs500.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel4.SetColumnSpan(this.Abs500, 2);
            this.Abs500.LargeChange = 10;
            this.Abs500.Location = new System.Drawing.Point(137, 335);
            this.Abs500.Margin = new System.Windows.Forms.Padding(4);
            this.Abs500.Maximum = 100;
            this.Abs500.Name = "Abs500";
            this.Abs500.Size = new System.Drawing.Size(258, 23);
            this.Abs500.TabIndex = 13;
            this.Abs500.TickFrequency = 10;
            this.Abs500.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Abs500.Value = 1;
            this.Abs500.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Abs1k
            // 
            this.Abs1k.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abs1k.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel4.SetColumnSpan(this.Abs1k, 2);
            this.Abs1k.LargeChange = 10;
            this.Abs1k.Location = new System.Drawing.Point(137, 366);
            this.Abs1k.Margin = new System.Windows.Forms.Padding(4);
            this.Abs1k.Maximum = 100;
            this.Abs1k.Name = "Abs1k";
            this.Abs1k.Size = new System.Drawing.Size(258, 23);
            this.Abs1k.TabIndex = 10;
            this.Abs1k.TickFrequency = 10;
            this.Abs1k.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Abs1k.Value = 1;
            this.Abs1k.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Abs2k
            // 
            this.Abs2k.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abs2k.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel4.SetColumnSpan(this.Abs2k, 2);
            this.Abs2k.LargeChange = 10;
            this.Abs2k.Location = new System.Drawing.Point(137, 397);
            this.Abs2k.Margin = new System.Windows.Forms.Padding(4);
            this.Abs2k.Maximum = 100;
            this.Abs2k.Name = "Abs2k";
            this.Abs2k.Size = new System.Drawing.Size(258, 23);
            this.Abs2k.TabIndex = 11;
            this.Abs2k.TickFrequency = 10;
            this.Abs2k.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Abs2k.Value = 1;
            this.Abs2k.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Abs4k
            // 
            this.Abs4k.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abs4k.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel4.SetColumnSpan(this.Abs4k, 2);
            this.Abs4k.LargeChange = 10;
            this.Abs4k.Location = new System.Drawing.Point(137, 428);
            this.Abs4k.Margin = new System.Windows.Forms.Padding(4);
            this.Abs4k.Maximum = 100;
            this.Abs4k.Name = "Abs4k";
            this.Abs4k.Size = new System.Drawing.Size(258, 23);
            this.Abs4k.TabIndex = 12;
            this.Abs4k.TickFrequency = 10;
            this.Abs4k.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Abs4k.Value = 1;
            this.Abs4k.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Abs8k
            // 
            this.Abs8k.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abs8k.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel4.SetColumnSpan(this.Abs8k, 2);
            this.Abs8k.LargeChange = 10;
            this.Abs8k.Location = new System.Drawing.Point(137, 459);
            this.Abs8k.Margin = new System.Windows.Forms.Padding(4);
            this.Abs8k.Maximum = 100;
            this.Abs8k.Name = "Abs8k";
            this.Abs8k.Size = new System.Drawing.Size(258, 23);
            this.Abs8k.TabIndex = 14;
            this.Abs8k.TickFrequency = 10;
            this.Abs8k.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Abs8k.Value = 1;
            this.Abs8k.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // AbsFlat
            // 
            this.AbsFlat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbsFlat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel4.SetColumnSpan(this.AbsFlat, 2);
            this.AbsFlat.LargeChange = 10;
            this.AbsFlat.Location = new System.Drawing.Point(137, 490);
            this.AbsFlat.Margin = new System.Windows.Forms.Padding(4);
            this.AbsFlat.Maximum = 100;
            this.AbsFlat.Name = "AbsFlat";
            this.AbsFlat.Size = new System.Drawing.Size(258, 23);
            this.AbsFlat.TabIndex = 46;
            this.AbsFlat.TickFrequency = 10;
            this.AbsFlat.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.AbsFlat.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // ScatFlat
            // 
            this.ScatFlat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScatFlat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ScatFlat.LargeChange = 10;
            this.ScatFlat.Location = new System.Drawing.Point(137, 410);
            this.ScatFlat.Margin = new System.Windows.Forms.Padding(4);
            this.ScatFlat.Maximum = 100;
            this.ScatFlat.Name = "ScatFlat";
            this.ScatFlat.Size = new System.Drawing.Size(259, 23);
            this.ScatFlat.TabIndex = 37;
            this.ScatFlat.TickFrequency = 10;
            this.ScatFlat.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.ScatFlat.Value = 1;
            this.ScatFlat.ValueChanged += new System.EventHandler(this.ScatFlat_ValueChanged);
            // 
            // Scat8kOut
            // 
            this.Scat8kOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scat8kOut.Location = new System.Drawing.Point(404, 379);
            this.Scat8kOut.Margin = new System.Windows.Forms.Padding(4);
            this.Scat8kOut.Name = "Scat8kOut";
            this.Scat8kOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Scat8kOut.Size = new System.Drawing.Size(72, 22);
            this.Scat8kOut.TabIndex = 45;
            this.Scat8kOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Scat8kOut.ValueChanged += new System.EventHandler(this.Scat8kOut_ValueChanged);
            // 
            // Scat8kv
            // 
            this.Scat8kv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scat8kv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Scat8kv.LargeChange = 10;
            this.Scat8kv.Location = new System.Drawing.Point(137, 379);
            this.Scat8kv.Margin = new System.Windows.Forms.Padding(4);
            this.Scat8kv.Maximum = 100;
            this.Scat8kv.Name = "Scat8kv";
            this.Scat8kv.Size = new System.Drawing.Size(259, 23);
            this.Scat8kv.TabIndex = 14;
            this.Scat8kv.TickFrequency = 10;
            this.Scat8kv.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Scat8kv.Value = 1;
            this.Scat8kv.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Scat4kv
            // 
            this.Scat4kv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scat4kv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Scat4kv.LargeChange = 10;
            this.Scat4kv.Location = new System.Drawing.Point(137, 348);
            this.Scat4kv.Margin = new System.Windows.Forms.Padding(4);
            this.Scat4kv.Maximum = 100;
            this.Scat4kv.Name = "Scat4kv";
            this.Scat4kv.Size = new System.Drawing.Size(259, 23);
            this.Scat4kv.TabIndex = 12;
            this.Scat4kv.TickFrequency = 10;
            this.Scat4kv.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Scat4kv.Value = 1;
            this.Scat4kv.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Scat4kOut
            // 
            this.Scat4kOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scat4kOut.Location = new System.Drawing.Point(404, 348);
            this.Scat4kOut.Margin = new System.Windows.Forms.Padding(4);
            this.Scat4kOut.Name = "Scat4kOut";
            this.Scat4kOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Scat4kOut.Size = new System.Drawing.Size(72, 22);
            this.Scat4kOut.TabIndex = 44;
            this.Scat4kOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Scat4kOut.ValueChanged += new System.EventHandler(this.Scat4kOut_ValueChanged);
            // 
            // Scat2kOut
            // 
            this.Scat2kOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scat2kOut.Location = new System.Drawing.Point(404, 317);
            this.Scat2kOut.Margin = new System.Windows.Forms.Padding(4);
            this.Scat2kOut.Name = "Scat2kOut";
            this.Scat2kOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Scat2kOut.Size = new System.Drawing.Size(72, 22);
            this.Scat2kOut.TabIndex = 43;
            this.Scat2kOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Scat2kOut.ValueChanged += new System.EventHandler(this.Scat2kOut_ValueChanged);
            // 
            // Scat2kv
            // 
            this.Scat2kv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scat2kv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Scat2kv.LargeChange = 10;
            this.Scat2kv.Location = new System.Drawing.Point(137, 317);
            this.Scat2kv.Margin = new System.Windows.Forms.Padding(4);
            this.Scat2kv.Maximum = 100;
            this.Scat2kv.Name = "Scat2kv";
            this.Scat2kv.Size = new System.Drawing.Size(259, 23);
            this.Scat2kv.TabIndex = 11;
            this.Scat2kv.TickFrequency = 10;
            this.Scat2kv.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Scat2kv.Value = 1;
            this.Scat2kv.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Scat1kv
            // 
            this.Scat1kv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scat1kv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Scat1kv.LargeChange = 10;
            this.Scat1kv.Location = new System.Drawing.Point(137, 286);
            this.Scat1kv.Margin = new System.Windows.Forms.Padding(4);
            this.Scat1kv.Maximum = 100;
            this.Scat1kv.Name = "Scat1kv";
            this.Scat1kv.Size = new System.Drawing.Size(259, 23);
            this.Scat1kv.TabIndex = 10;
            this.Scat1kv.TickFrequency = 10;
            this.Scat1kv.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Scat1kv.Value = 1;
            this.Scat1kv.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Scat1kOut
            // 
            this.Scat1kOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scat1kOut.Location = new System.Drawing.Point(404, 286);
            this.Scat1kOut.Margin = new System.Windows.Forms.Padding(4);
            this.Scat1kOut.Name = "Scat1kOut";
            this.Scat1kOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Scat1kOut.Size = new System.Drawing.Size(72, 22);
            this.Scat1kOut.TabIndex = 42;
            this.Scat1kOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Scat1kOut.ValueChanged += new System.EventHandler(this.Scat1kOut_ValueChanged);
            // 
            // Scat500Out
            // 
            this.Scat500Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scat500Out.Location = new System.Drawing.Point(404, 255);
            this.Scat500Out.Margin = new System.Windows.Forms.Padding(4);
            this.Scat500Out.Name = "Scat500Out";
            this.Scat500Out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Scat500Out.Size = new System.Drawing.Size(72, 22);
            this.Scat500Out.TabIndex = 41;
            this.Scat500Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Scat500Out.ValueChanged += new System.EventHandler(this.Scat500Out_ValueChanged);
            // 
            // Scat500v
            // 
            this.Scat500v.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scat500v.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Scat500v.LargeChange = 10;
            this.Scat500v.Location = new System.Drawing.Point(137, 255);
            this.Scat500v.Margin = new System.Windows.Forms.Padding(4);
            this.Scat500v.Maximum = 100;
            this.Scat500v.Name = "Scat500v";
            this.Scat500v.Size = new System.Drawing.Size(259, 23);
            this.Scat500v.TabIndex = 13;
            this.Scat500v.TickFrequency = 10;
            this.Scat500v.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Scat500v.Value = 1;
            this.Scat500v.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Scat250v
            // 
            this.Scat250v.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scat250v.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Scat250v.LargeChange = 10;
            this.Scat250v.Location = new System.Drawing.Point(137, 224);
            this.Scat250v.Margin = new System.Windows.Forms.Padding(4);
            this.Scat250v.Maximum = 100;
            this.Scat250v.Name = "Scat250v";
            this.Scat250v.Size = new System.Drawing.Size(259, 23);
            this.Scat250v.TabIndex = 9;
            this.Scat250v.TickFrequency = 10;
            this.Scat250v.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Scat250v.Value = 1;
            this.Scat250v.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Scat250Out
            // 
            this.Scat250Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scat250Out.Location = new System.Drawing.Point(404, 224);
            this.Scat250Out.Margin = new System.Windows.Forms.Padding(4);
            this.Scat250Out.Name = "Scat250Out";
            this.Scat250Out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Scat250Out.Size = new System.Drawing.Size(72, 22);
            this.Scat250Out.TabIndex = 40;
            this.Scat250Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Scat250Out.ValueChanged += new System.EventHandler(this.Scat250Out_ValueChanged);
            // 
            // Scat125Out
            // 
            this.Scat125Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scat125Out.Location = new System.Drawing.Point(404, 193);
            this.Scat125Out.Margin = new System.Windows.Forms.Padding(4);
            this.Scat125Out.Name = "Scat125Out";
            this.Scat125Out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Scat125Out.Size = new System.Drawing.Size(72, 22);
            this.Scat125Out.TabIndex = 39;
            this.Scat125Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Scat125Out.ValueChanged += new System.EventHandler(this.Scat125Out_ValueChanged);
            // 
            // Scat125v
            // 
            this.Scat125v.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scat125v.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Scat125v.LargeChange = 10;
            this.Scat125v.Location = new System.Drawing.Point(137, 193);
            this.Scat125v.Margin = new System.Windows.Forms.Padding(4);
            this.Scat125v.Maximum = 100;
            this.Scat125v.Name = "Scat125v";
            this.Scat125v.Size = new System.Drawing.Size(259, 23);
            this.Scat125v.TabIndex = 15;
            this.Scat125v.TickFrequency = 10;
            this.Scat125v.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Scat125v.Value = 1;
            this.Scat125v.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Scat63v
            // 
            this.Scat63v.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scat63v.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Scat63v.LargeChange = 10;
            this.Scat63v.Location = new System.Drawing.Point(137, 162);
            this.Scat63v.Margin = new System.Windows.Forms.Padding(4);
            this.Scat63v.Maximum = 100;
            this.Scat63v.Name = "Scat63v";
            this.Scat63v.Size = new System.Drawing.Size(259, 23);
            this.Scat63v.TabIndex = 16;
            this.Scat63v.TickFrequency = 10;
            this.Scat63v.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Scat63v.Value = 1;
            this.Scat63v.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Scat63Out
            // 
            this.Scat63Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Scat63Out.Location = new System.Drawing.Point(404, 162);
            this.Scat63Out.Margin = new System.Windows.Forms.Padding(4);
            this.Scat63Out.Name = "Scat63Out";
            this.Scat63Out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Scat63Out.Size = new System.Drawing.Size(72, 22);
            this.Scat63Out.TabIndex = 38;
            this.Scat63Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Scat63Out.ValueChanged += new System.EventHandler(this.Scat63Out_ValueChanged);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label22.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.label22, 3);
            this.label22.Location = new System.Drawing.Point(4, 141);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(369, 17);
            this.label22.TabIndex = 30;
            this.label22.Text = "Scattering Coefficients (% non-specular reflected energy)";
            // 
            // SmartMat_Display
            // 
            this.SmartMat_Display.BackColor = System.Drawing.Color.Transparent;
            customLabel13.FromPosition = 1D;
            customLabel13.Text = "0";
            customLabel13.ToPosition = 2D;
            customLabel14.FromPosition = 1D;
            customLabel14.Text = "30";
            customLabel14.ToPosition = 2D;
            customLabel15.FromPosition = 2D;
            customLabel15.Text = "60";
            customLabel15.ToPosition = 3D;
            customLabel16.FromPosition = 3D;
            customLabel16.Text = "90";
            customLabel16.ToPosition = 4D;
            customLabel22.FromPosition = 8D;
            customLabel22.Text = "-90";
            customLabel22.ToPosition = 9D;
            customLabel23.FromPosition = 9D;
            customLabel23.Text = "-60";
            customLabel23.ToPosition = 10D;
            customLabel24.FromPosition = 11D;
            customLabel24.Text = "-30";
            customLabel24.ToPosition = 12D;
            chartArea2.AxisX.CustomLabels.Add(customLabel13);
            chartArea2.AxisX.CustomLabels.Add(customLabel14);
            chartArea2.AxisX.CustomLabels.Add(customLabel15);
            chartArea2.AxisX.CustomLabels.Add(customLabel16);
            chartArea2.AxisX.CustomLabels.Add(customLabel17);
            chartArea2.AxisX.CustomLabels.Add(customLabel18);
            chartArea2.AxisX.CustomLabels.Add(customLabel19);
            chartArea2.AxisX.CustomLabels.Add(customLabel20);
            chartArea2.AxisX.CustomLabels.Add(customLabel21);
            chartArea2.AxisX.CustomLabels.Add(customLabel22);
            chartArea2.AxisX.CustomLabels.Add(customLabel23);
            chartArea2.AxisX.CustomLabels.Add(customLabel24);
            chartArea2.Name = "ChartArea1";
            this.SmartMat_Display.ChartAreas.Add(chartArea2);
            this.SmartMat_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Left;
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            legend2.Position.Auto = false;
            legend2.Position.Height = 25F;
            legend2.Position.Width = 20F;
            legend2.Position.X = 80F;
            legend2.Position.Y = 75F;
            this.SmartMat_Display.Legends.Add(legend2);
            this.SmartMat_Display.Location = new System.Drawing.Point(4, 4);
            this.SmartMat_Display.Margin = new System.Windows.Forms.Padding(4);
            this.SmartMat_Display.Name = "SmartMat_Display";
            this.SmartMat_Display.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.SmartMat_Display.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.Color.Gold,
        System.Drawing.Color.GreenYellow,
        System.Drawing.Color.Green,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Indigo,
        System.Drawing.Color.Violet};
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series9.CustomProperties = "CircularLabelsStyle=Circular";
            series9.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series9.Legend = "Legend1";
            series9.Name = "62.5 Hz.";
            series9.ShadowColor = System.Drawing.Color.DarkGray;
            series9.ShadowOffset = 3;
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series10.Legend = "Legend1";
            series10.Name = "125 Hz.";
            series10.ShadowColor = System.Drawing.Color.DarkGray;
            series10.ShadowOffset = 3;
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series11.Legend = "Legend1";
            series11.Name = "250 Hz.";
            series11.ShadowColor = System.Drawing.Color.DarkGray;
            series11.ShadowOffset = 3;
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series12.Legend = "Legend1";
            series12.Name = "500 Hz.";
            series12.ShadowColor = System.Drawing.Color.DarkGray;
            series12.ShadowOffset = 3;
            series13.BorderWidth = 3;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series13.Legend = "Legend1";
            series13.Name = "1000 Hz.";
            series13.ShadowColor = System.Drawing.Color.DarkGray;
            series13.ShadowOffset = 3;
            series14.BorderWidth = 3;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series14.Legend = "Legend1";
            series14.Name = "2000 Hz.";
            series14.ShadowColor = System.Drawing.Color.DarkGray;
            series14.ShadowOffset = 3;
            series15.BorderWidth = 3;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series15.Legend = "Legend1";
            series15.Name = "4000 Hz.";
            series15.ShadowColor = System.Drawing.Color.DarkGray;
            series15.ShadowOffset = 3;
            series16.BorderWidth = 3;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            series16.Legend = "Legend1";
            series16.Name = "8000 Hz.";
            series16.ShadowColor = System.Drawing.Color.DarkGray;
            series16.ShadowOffset = 3;
            this.SmartMat_Display.Series.Add(series9);
            this.SmartMat_Display.Series.Add(series10);
            this.SmartMat_Display.Series.Add(series11);
            this.SmartMat_Display.Series.Add(series12);
            this.SmartMat_Display.Series.Add(series13);
            this.SmartMat_Display.Series.Add(series14);
            this.SmartMat_Display.Series.Add(series15);
            this.SmartMat_Display.Series.Add(series16);
            this.SmartMat_Display.Size = new System.Drawing.Size(493, 619);
            this.SmartMat_Display.TabIndex = 45;
            this.SmartMat_Display.TabStop = false;
            this.SmartMat_Display.Text = "Absorption By Angle";
            // 
            // Calculate
            // 
            this.tableLayoutPanel7.SetColumnSpan(this.Calculate, 5);
            this.Calculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Calculate.Location = new System.Drawing.Point(3, 304);
            this.Calculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(511, 36);
            this.Calculate.TabIndex = 15;
            this.Calculate.Text = "Calculate Solution";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // RTBox
            // 
            this.RTBox.AutoSize = true;
            this.RTBox.Checked = true;
            this.RTBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel7.SetColumnSpan(this.RTBox, 2);
            this.RTBox.Location = new System.Drawing.Point(4, 175);
            this.RTBox.Margin = new System.Windows.Forms.Padding(4);
            this.RTBox.Name = "RTBox";
            this.RTBox.Size = new System.Drawing.Size(136, 21);
            this.RTBox.TabIndex = 8;
            this.RTBox.Text = "Raytracing Solution";
            this.RTBox.UseVisualStyleBackColor = true;
            this.RTBox.CheckedChanged += new System.EventHandler(this.CalcType_CheckedChanged);
            // 
            // ISBox
            // 
            this.ISBox.AutoSize = true;
            this.ISBox.Checked = true;
            this.ISBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel7.SetColumnSpan(this.ISBox, 2);
            this.ISBox.Location = new System.Drawing.Point(4, 45);
            this.ISBox.Margin = new System.Windows.Forms.Padding(4);
            this.ISBox.Name = "ISBox";
            this.ISBox.Size = new System.Drawing.Size(136, 21);
            this.ISBox.TabIndex = 4;
            this.ISBox.Text = "Image Source Solution";
            this.ISBox.UseVisualStyleBackColor = true;
            this.ISBox.CheckedChanged += new System.EventHandler(this.CalcType_CheckedChanged);
            // 
            // Tabs
            // 
            this.Tabs.AccessibleDescription = "";
            this.Tabs.AccessibleName = "";
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.TabPage1);
            this.Tabs.Controls.Add(this.TabPage4);
            this.Tabs.Controls.Add(this.TabPage3);
            this.Tabs.Location = new System.Drawing.Point(4, 33);
            this.Tabs.Margin = new System.Windows.Forms.Padding(4);
            this.Tabs.MinimumSize = new System.Drawing.Size(533, 492);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(533, 734);
            this.Tabs.TabIndex = 5;
            this.Tabs.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.Tab_Selecting);
            // 
            // TabPage1
            // 
            this.TabPage1.AutoScroll = true;
            this.TabPage1.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.TabPage1.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.TabPage1.Controls.Add(this.tableLayoutPanel7);
            this.TabPage1.Location = new System.Drawing.Point(4, 25);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage1.Size = new System.Drawing.Size(525, 705);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Impulse";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 5;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Controls.Add(this.GroupBox4, 1, 12);
            this.tableLayoutPanel7.Controls.Add(this.Calculate, 1, 11);
            this.tableLayoutPanel7.Controls.Add(this.CO_TIME, 4, 10);
            this.tableLayoutPanel7.Controls.Add(this.Spec_Rays, 2, 8);
            this.tableLayoutPanel7.Controls.Add(this.ReceiverSelection, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.RT_Count, 4, 9);
            this.tableLayoutPanel7.Controls.Add(this.Label2, 1, 9);
            this.tableLayoutPanel7.Controls.Add(this.Spec_RayCount, 4, 5);
            this.tableLayoutPanel7.Controls.Add(this.label14, 4, 4);
            this.tableLayoutPanel7.Controls.Add(this.Image_Order, 4, 3);
            this.tableLayoutPanel7.Controls.Add(this.DetailedConvergence, 4, 8);
            this.tableLayoutPanel7.Controls.Add(this.Minimum_Convergence, 3, 8);
            this.tableLayoutPanel7.Controls.Add(this.ISBox, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.RTBox, 0, 7);
            this.tableLayoutPanel7.Controls.Add(this.Label1, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.BTM_ED, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.Specular_Trace, 1, 5);
            this.tableLayoutPanel7.Controls.Add(this.label4, 1, 8);
            this.tableLayoutPanel7.Controls.Add(this.COTime, 1, 10);
            this.tableLayoutPanel7.Controls.Add(this.Label17, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 13;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(517, 697);
            this.tableLayoutPanel7.TabIndex = 89;
            // 
            // GroupBox4
            // 
            this.tableLayoutPanel7.SetColumnSpan(this.GroupBox4, 5);
            this.GroupBox4.Controls.Add(this.EdgeFreq);
            this.GroupBox4.Controls.Add(this.Label21);
            this.GroupBox4.Controls.Add(this.Atten_Method);
            this.GroupBox4.Controls.Add(this.Label19);
            this.GroupBox4.Controls.Add(this.Air_Pressure);
            this.GroupBox4.Controls.Add(this.Label3);
            this.GroupBox4.Controls.Add(this.Rel_Humidity);
            this.GroupBox4.Controls.Add(this.AirTemp);
            this.GroupBox4.Controls.Add(this.Air_Temp);
            this.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox4.Location = new System.Drawing.Point(4, 346);
            this.GroupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox4.Size = new System.Drawing.Size(509, 181);
            this.GroupBox4.TabIndex = 33;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Environmental Factors";
            // 
            // EdgeFreq
            // 
            this.EdgeFreq.AutoSize = true;
            this.EdgeFreq.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EdgeFreq.Location = new System.Drawing.Point(93, 151);
            this.EdgeFreq.Margin = new System.Windows.Forms.Padding(4);
            this.EdgeFreq.Name = "EdgeFreq";
            this.EdgeFreq.Size = new System.Drawing.Size(203, 21);
            this.EdgeFreq.TabIndex = 35;
            this.EdgeFreq.Text = "Edge Frequency Correction";
            this.EdgeFreq.UseVisualStyleBackColor = true;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(11, 122);
            this.Label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(59, 17);
            this.Label21.TabIndex = 34;
            this.Label21.Text = "Method:";
            // 
            // Atten_Method
            // 
            this.Atten_Method.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Atten_Method.FormattingEnabled = true;
            this.Atten_Method.Items.AddRange(new object[] {
            "ISO 9613-1 (Outdoor Attenuation)",
            "Evans & Bazley (Indoor Attenuation)",
            "Known values (Vorlander)"});
            this.Atten_Method.Location = new System.Drawing.Point(93, 118);
            this.Atten_Method.Margin = new System.Windows.Forms.Padding(4);
            this.Atten_Method.Name = "Atten_Method";
            this.Atten_Method.Size = new System.Drawing.Size(402, 24);
            this.Atten_Method.TabIndex = 14;
            this.Atten_Method.Text = "ISO 9613-1 (Outdoor Attenuation)";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(11, 89);
            this.Label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(164, 17);
            this.Label19.TabIndex = 32;
            this.Label19.Text = "Static Air Pressure (hPa)";
            // 
            // Air_Pressure
            // 
            this.Air_Pressure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Air_Pressure.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Air_Pressure.Location = new System.Drawing.Point(411, 86);
            this.Air_Pressure.Margin = new System.Windows.Forms.Padding(4);
            this.Air_Pressure.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.Air_Pressure.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.Air_Pressure.Name = "Air_Pressure";
            this.Air_Pressure.Size = new System.Drawing.Size(85, 22);
            this.Air_Pressure.TabIndex = 13;
            this.Air_Pressure.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(11, 57);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(139, 17);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "Relative Humidity(%)";
            // 
            // Rel_Humidity
            // 
            this.Rel_Humidity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rel_Humidity.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Rel_Humidity.Location = new System.Drawing.Point(454, 54);
            this.Rel_Humidity.Margin = new System.Windows.Forms.Padding(4);
            this.Rel_Humidity.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.Rel_Humidity.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.Rel_Humidity.Name = "Rel_Humidity";
            this.Rel_Humidity.Size = new System.Drawing.Size(43, 22);
            this.Rel_Humidity.TabIndex = 12;
            this.Rel_Humidity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // AirTemp
            // 
            this.AirTemp.AutoSize = true;
            this.AirTemp.Location = new System.Drawing.Point(11, 25);
            this.AirTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AirTemp.Name = "AirTemp";
            this.AirTemp.Size = new System.Drawing.Size(134, 17);
            this.AirTemp.TabIndex = 28;
            this.AirTemp.Text = "Air Temperature (C)";
            // 
            // Air_Temp
            // 
            this.Air_Temp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Air_Temp.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Air_Temp.Location = new System.Drawing.Point(454, 22);
            this.Air_Temp.Margin = new System.Windows.Forms.Padding(4);
            this.Air_Temp.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.Air_Temp.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.Air_Temp.Name = "Air_Temp";
            this.Air_Temp.Size = new System.Drawing.Size(43, 22);
            this.Air_Temp.TabIndex = 11;
            this.Air_Temp.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // CO_TIME
            // 
            this.CO_TIME.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CO_TIME.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.CO_TIME.Location = new System.Drawing.Point(428, 265);
            this.CO_TIME.Margin = new System.Windows.Forms.Padding(4);
            this.CO_TIME.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.CO_TIME.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CO_TIME.Name = "CO_TIME";
            this.CO_TIME.Size = new System.Drawing.Size(85, 22);
            this.CO_TIME.TabIndex = 10;
            this.CO_TIME.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // Spec_Rays
            // 
            this.Spec_Rays.AutoSize = true;
            this.Spec_Rays.Location = new System.Drawing.Point(147, 204);
            this.Spec_Rays.Name = "Spec_Rays";
            this.Spec_Rays.Size = new System.Drawing.Size(118, 21);
            this.Spec_Rays.TabIndex = 88;
            this.Spec_Rays.Text = "Specify Ray Count";
            this.Spec_Rays.UseVisualStyleBackColor = true;
            this.Spec_Rays.CheckedChanged += new System.EventHandler(this.Convergence_CheckedChanged);
            // 
            // ReceiverSelection
            // 
            this.ReceiverSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.SetColumnSpan(this.ReceiverSelection, 3);
            this.ReceiverSelection.FormattingEnabled = true;
            this.ReceiverSelection.Items.AddRange(new object[] {
            "1 m. Stationary Receiver",
            "Expanding Receiver (Expanding)"});
            this.ReceiverSelection.Location = new System.Drawing.Point(148, 4);
            this.ReceiverSelection.Margin = new System.Windows.Forms.Padding(4);
            this.ReceiverSelection.Name = "ReceiverSelection";
            this.ReceiverSelection.Size = new System.Drawing.Size(365, 24);
            this.ReceiverSelection.TabIndex = 3;
            this.ReceiverSelection.Text = "1 m. Stationary Receiver";
            // 
            // RT_Count
            // 
            this.RT_Count.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RT_Count.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.RT_Count.Enabled = false;
            this.RT_Count.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RT_Count.Location = new System.Drawing.Point(428, 235);
            this.RT_Count.Margin = new System.Windows.Forms.Padding(4);
            this.RT_Count.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.RT_Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RT_Count.Name = "RT_Count";
            this.RT_Count.Size = new System.Drawing.Size(85, 22);
            this.RT_Count.TabIndex = 9;
            this.RT_Count.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(24, 231);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(110, 17);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Number of Rays";
            // 
            // Spec_RayCount
            // 
            this.Spec_RayCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Spec_RayCount.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Spec_RayCount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Spec_RayCount.Location = new System.Drawing.Point(428, 135);
            this.Spec_RayCount.Margin = new System.Windows.Forms.Padding(4);
            this.Spec_RayCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Spec_RayCount.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Spec_RayCount.Name = "Spec_RayCount";
            this.Spec_RayCount.Size = new System.Drawing.Size(85, 22);
            this.Spec_RayCount.TabIndex = 7;
            this.Spec_RayCount.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Red;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Location = new System.Drawing.Point(425, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 17);
            this.label14.TabIndex = 85;
            this.label14.Text = "Experimental";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Image_Order
            // 
            this.Image_Order.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Image_Order.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Image_Order.Location = new System.Drawing.Point(453, 75);
            this.Image_Order.Margin = new System.Windows.Forms.Padding(4);
            this.Image_Order.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Image_Order.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Image_Order.Name = "Image_Order";
            this.Image_Order.Size = new System.Drawing.Size(60, 22);
            this.Image_Order.TabIndex = 5;
            this.Image_Order.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DetailedConvergence
            // 
            this.DetailedConvergence.AutoSize = true;
            this.DetailedConvergence.Location = new System.Drawing.Point(395, 204);
            this.DetailedConvergence.Name = "DetailedConvergence";
            this.DetailedConvergence.Size = new System.Drawing.Size(119, 21);
            this.DetailedConvergence.TabIndex = 87;
            this.DetailedConvergence.Text = "Detailed Convergence";
            this.DetailedConvergence.UseVisualStyleBackColor = true;
            this.DetailedConvergence.CheckedChanged += new System.EventHandler(this.Convergence_CheckedChanged);
            // 
            // Minimum_Convergence
            // 
            this.Minimum_Convergence.AutoSize = true;
            this.Minimum_Convergence.Checked = true;
            this.Minimum_Convergence.Location = new System.Drawing.Point(271, 204);
            this.Minimum_Convergence.Name = "Minimum_Convergence";
            this.Minimum_Convergence.Size = new System.Drawing.Size(118, 21);
            this.Minimum_Convergence.TabIndex = 86;
            this.Minimum_Convergence.TabStop = true;
            this.Minimum_Convergence.Text = "Minimum Convergence";
            this.Minimum_Convergence.UseVisualStyleBackColor = true;
            this.Minimum_Convergence.CheckedChanged += new System.EventHandler(this.Convergence_CheckedChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(24, 71);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 17);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Reflection Order";
            // 
            // BTM_ED
            // 
            this.BTM_ED.AutoSize = true;
            this.BTM_ED.Location = new System.Drawing.Point(24, 105);
            this.BTM_ED.Margin = new System.Windows.Forms.Padding(4);
            this.BTM_ED.Name = "BTM_ED";
            this.BTM_ED.Size = new System.Drawing.Size(116, 21);
            this.BTM_ED.TabIndex = 34;
            this.BTM_ED.Text = "BTM Edge Diffraction";
            this.BTM_ED.UseVisualStyleBackColor = true;
            // 
            // Specular_Trace
            // 
            this.Specular_Trace.AutoSize = true;
            this.Specular_Trace.Enabled = false;
            this.Specular_Trace.Location = new System.Drawing.Point(24, 135);
            this.Specular_Trace.Margin = new System.Windows.Forms.Padding(4);
            this.Specular_Trace.Name = "Specular_Trace";
            this.Specular_Trace.Size = new System.Drawing.Size(116, 21);
            this.Specular_Trace.TabIndex = 6;
            this.Specular_Trace.Text = "Image Source Tracing";
            this.Specular_Trace.UseVisualStyleBackColor = true;
            this.Specular_Trace.CheckedChanged += new System.EventHandler(this.CalcType_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 90;
            this.label4.Text = "Convergence:";
            // 
            // COTime
            // 
            this.COTime.AutoSize = true;
            this.COTime.Location = new System.Drawing.Point(24, 261);
            this.COTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.COTime.Name = "COTime";
            this.COTime.Size = new System.Drawing.Size(91, 30);
            this.COTime.TabIndex = 17;
            this.COTime.Text = "Cut Off Time (ms)";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.tableLayoutPanel7.SetColumnSpan(this.Label17, 2);
            this.Label17.Location = new System.Drawing.Point(4, 0);
            this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(68, 17);
            this.Label17.TabIndex = 31;
            this.Label17.Text = "Receiver:";
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.tableLayoutPanel2);
            this.TabPage4.Location = new System.Drawing.Point(4, 25);
            this.TabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage4.Size = new System.Drawing.Size(525, 705);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Materials";
            this.TabPage4.UseVisualStyleBackColor = true;
            this.TabPage4.MouseEnter += new System.EventHandler(this.Materials_MouseEnter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.5F));
            this.tableLayoutPanel2.Controls.Add(this.LayerLbl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.LayerDisplay, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.734577F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.26543F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(517, 697);
            this.tableLayoutPanel2.TabIndex = 46;
            // 
            // LayerLbl
            // 
            this.LayerLbl.AutoSize = true;
            this.LayerLbl.Location = new System.Drawing.Point(4, 0);
            this.LayerLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LayerLbl.Name = "LayerLbl";
            this.LayerLbl.Size = new System.Drawing.Size(73, 17);
            this.LayerLbl.TabIndex = 6;
            this.LayerLbl.Text = "For Layer:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.tabControl1, 2);
            this.tabControl1.Controls.Add(this.Absorption);
            this.tabControl1.Controls.Add(this.Scattering);
            this.tabControl1.Controls.Add(this.Transparency);
            this.tabControl1.Location = new System.Drawing.Point(4, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 656);
            this.tabControl1.TabIndex = 47;
            // 
            // Absorption
            // 
            this.Absorption.Controls.Add(this.tableLayoutPanel4);
            this.Absorption.Controls.Add(this.SmartMat_Display);
            this.Absorption.Location = new System.Drawing.Point(4, 25);
            this.Absorption.Margin = new System.Windows.Forms.Padding(4);
            this.Absorption.Name = "Absorption";
            this.Absorption.Padding = new System.Windows.Forms.Padding(4);
            this.Absorption.Size = new System.Drawing.Size(501, 627);
            this.Absorption.TabIndex = 0;
            this.Absorption.Text = "Absorption";
            this.Absorption.UseVisualStyleBackColor = true;
            // 
            // Scattering
            // 
            this.Scattering.Controls.Add(this.tableLayoutPanel5);
            this.Scattering.Location = new System.Drawing.Point(4, 25);
            this.Scattering.Margin = new System.Windows.Forms.Padding(4);
            this.Scattering.Name = "Scattering";
            this.Scattering.Padding = new System.Windows.Forms.Padding(4);
            this.Scattering.Size = new System.Drawing.Size(501, 627);
            this.Scattering.TabIndex = 1;
            this.Scattering.Text = "Scattering";
            this.Scattering.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel5.Controls.Add(this.quart_lambda, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.user_quart_lambda, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label37, 0, 13);
            this.tableLayoutPanel5.Controls.Add(this.ScatFlat, 1, 13);
            this.tableLayoutPanel5.Controls.Add(this.label38, 0, 12);
            this.tableLayoutPanel5.Controls.Add(this.PlasterScatter, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.Scat8kOut, 2, 12);
            this.tableLayoutPanel5.Controls.Add(this.GlassScatter, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label39, 0, 11);
            this.tableLayoutPanel5.Controls.Add(this.Scat8kv, 1, 12);
            this.tableLayoutPanel5.Controls.Add(this.label40, 0, 10);
            this.tableLayoutPanel5.Controls.Add(this.label41, 0, 9);
            this.tableLayoutPanel5.Controls.Add(this.label42, 0, 8);
            this.tableLayoutPanel5.Controls.Add(this.Scat4kOut, 2, 11);
            this.tableLayoutPanel5.Controls.Add(this.Scat4kv, 1, 11);
            this.tableLayoutPanel5.Controls.Add(this.label43, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.label44, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.Scat2kOut, 2, 10);
            this.tableLayoutPanel5.Controls.Add(this.label45, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.Scat2kv, 1, 10);
            this.tableLayoutPanel5.Controls.Add(this.label22, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.Scat63v, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.Scat63Out, 2, 5);
            this.tableLayoutPanel5.Controls.Add(this.Scat1kOut, 2, 9);
            this.tableLayoutPanel5.Controls.Add(this.Scat1kv, 1, 9);
            this.tableLayoutPanel5.Controls.Add(this.Scat125Out, 2, 6);
            this.tableLayoutPanel5.Controls.Add(this.Scat125v, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.Scat500Out, 2, 8);
            this.tableLayoutPanel5.Controls.Add(this.Scat250v, 1, 7);
            this.tableLayoutPanel5.Controls.Add(this.Scat500v, 1, 8);
            this.tableLayoutPanel5.Controls.Add(this.Scat250Out, 2, 7);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 15;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(493, 619);
            this.tableLayoutPanel5.TabIndex = 46;
            // 
            // quart_lambda
            // 
            this.quart_lambda.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.quart_lambda, 2);
            this.quart_lambda.Dock = System.Windows.Forms.DockStyle.Right;
            this.quart_lambda.Location = new System.Drawing.Point(436, 93);
            this.quart_lambda.Name = "quart_lambda";
            this.quart_lambda.Size = new System.Drawing.Size(54, 47);
            this.quart_lambda.TabIndex = 50;
            this.quart_lambda.Text = "25 mm.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.label16, 4);
            this.label16.Location = new System.Drawing.Point(3, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(246, 17);
            this.label16.TabIndex = 51;
            this.label16.Text = "Variegation (characteristic dimension)";
            // 
            // user_quart_lambda
            // 
            this.user_quart_lambda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_quart_lambda.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel5.SetColumnSpan(this.user_quart_lambda, 2);
            this.user_quart_lambda.LargeChange = 10;
            this.user_quart_lambda.Location = new System.Drawing.Point(4, 97);
            this.user_quart_lambda.Margin = new System.Windows.Forms.Padding(4);
            this.user_quart_lambda.Maximum = 700;
            this.user_quart_lambda.Name = "user_quart_lambda";
            this.user_quart_lambda.Size = new System.Drawing.Size(392, 39);
            this.user_quart_lambda.TabIndex = 49;
            this.user_quart_lambda.TickFrequency = 10;
            this.user_quart_lambda.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.user_quart_lambda.Value = 25;
            this.user_quart_lambda.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label37
            // 
            this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(4, 406);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(70, 31);
            this.label37.TabIndex = 38;
            this.label37.Text = "Flatten All";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(4, 375);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(44, 31);
            this.label38.TabIndex = 24;
            this.label38.Text = "8 kHz";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlasterScatter
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.PlasterScatter, 4);
            this.PlasterScatter.Location = new System.Drawing.Point(3, 38);
            this.PlasterScatter.Name = "PlasterScatter";
            this.PlasterScatter.Size = new System.Drawing.Size(484, 26);
            this.PlasterScatter.TabIndex = 48;
            this.PlasterScatter.Text = "Flat (plaster/gypsum)";
            this.PlasterScatter.UseVisualStyleBackColor = true;
            this.PlasterScatter.Click += new System.EventHandler(this.PlasterScatter_Click);
            // 
            // GlassScatter
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.GlassScatter, 4);
            this.GlassScatter.Location = new System.Drawing.Point(3, 3);
            this.GlassScatter.Name = "GlassScatter";
            this.GlassScatter.Size = new System.Drawing.Size(484, 24);
            this.GlassScatter.TabIndex = 47;
            this.GlassScatter.Text = "Flat (Glass)";
            this.GlassScatter.UseVisualStyleBackColor = true;
            this.GlassScatter.Click += new System.EventHandler(this.GlassScatter_Click);
            // 
            // label39
            // 
            this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(4, 344);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(44, 31);
            this.label39.TabIndex = 22;
            this.label39.Text = "4 kHz";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label40
            // 
            this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(4, 313);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(44, 31);
            this.label40.TabIndex = 21;
            this.label40.Text = "2 kHz";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label41
            // 
            this.label41.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(4, 282);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(44, 31);
            this.label41.TabIndex = 20;
            this.label41.Text = "1 kHz";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label42
            // 
            this.label42.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(4, 251);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(53, 31);
            this.label42.TabIndex = 19;
            this.label42.Text = "500 Hz";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label43
            // 
            this.label43.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(4, 220);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(53, 31);
            this.label43.TabIndex = 25;
            this.label43.Text = "250 Hz";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label44
            // 
            this.label44.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(4, 189);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(53, 31);
            this.label44.TabIndex = 18;
            this.label44.Text = "125 Hz";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label45
            // 
            this.label45.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(4, 158);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(57, 31);
            this.label45.TabIndex = 17;
            this.label45.Text = "62.5 Hz";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Transparency
            // 
            this.Transparency.Controls.Add(this.tabControl2);
            this.Transparency.Location = new System.Drawing.Point(4, 25);
            this.Transparency.Margin = new System.Windows.Forms.Padding(4);
            this.Transparency.Name = "Transparency";
            this.Transparency.Size = new System.Drawing.Size(501, 627);
            this.Transparency.TabIndex = 2;
            this.Transparency.Text = "Transparency";
            this.Transparency.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(501, 627);
            this.tabControl2.TabIndex = 48;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(493, 598);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Transmission Coefficient";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel6.Controls.Add(this.Trans_Flat, 1, 9);
            this.tableLayoutPanel6.Controls.Add(this.Trans_8k_Out, 2, 8);
            this.tableLayoutPanel6.Controls.Add(this.label29, 0, 7);
            this.tableLayoutPanel6.Controls.Add(this.Trans_8kv, 1, 8);
            this.tableLayoutPanel6.Controls.Add(this.label30, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.label31, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.label32, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.Trans_4k_Out, 2, 7);
            this.tableLayoutPanel6.Controls.Add(this.Trans_4kv, 1, 7);
            this.tableLayoutPanel6.Controls.Add(this.label33, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label34, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.Trans_2k_Out, 2, 6);
            this.tableLayoutPanel6.Controls.Add(this.label35, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.Trans_2kv, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.label36, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.Trans_63v, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.Trans_63_Out, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.Trans_1k_Out, 2, 5);
            this.tableLayoutPanel6.Controls.Add(this.Trans_1kv, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.Trans_125_Out, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.Trans_125v, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.Trans_500_Out, 2, 4);
            this.tableLayoutPanel6.Controls.Add(this.Trans_250v, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.Trans_500v, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.Trans_250_Out, 2, 3);
            this.tableLayoutPanel6.Controls.Add(this.Trans_Check, 1, 10);
            this.tableLayoutPanel6.Controls.Add(this.label28, 0, 8);
            this.tableLayoutPanel6.Controls.Add(this.label23, 0, 9);
            this.tableLayoutPanel6.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(7, 8);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 11;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(479, 1113);
            this.tableLayoutPanel6.TabIndex = 47;
            // 
            // Trans_Flat
            // 
            this.Trans_Flat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trans_Flat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Trans_Flat.Enabled = false;
            this.Trans_Flat.LargeChange = 10;
            this.Trans_Flat.Location = new System.Drawing.Point(137, 270);
            this.Trans_Flat.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_Flat.Maximum = 100;
            this.Trans_Flat.Name = "Trans_Flat";
            this.Trans_Flat.Size = new System.Drawing.Size(245, 23);
            this.Trans_Flat.TabIndex = 37;
            this.Trans_Flat.TickFrequency = 10;
            this.Trans_Flat.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Trans_Flat.ValueChanged += new System.EventHandler(this.TransFlat_ValueChanged);
            // 
            // Trans_8k_Out
            // 
            this.Trans_8k_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trans_8k_Out.Enabled = false;
            this.Trans_8k_Out.Location = new System.Drawing.Point(390, 239);
            this.Trans_8k_Out.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_8k_Out.Name = "Trans_8k_Out";
            this.Trans_8k_Out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Trans_8k_Out.Size = new System.Drawing.Size(72, 22);
            this.Trans_8k_Out.TabIndex = 45;
            this.Trans_8k_Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Trans_8k_Out.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(4, 204);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(44, 31);
            this.label29.TabIndex = 22;
            this.label29.Text = "4 kHz";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Trans_8kv
            // 
            this.Trans_8kv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trans_8kv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Trans_8kv.Enabled = false;
            this.Trans_8kv.LargeChange = 10;
            this.Trans_8kv.Location = new System.Drawing.Point(137, 239);
            this.Trans_8kv.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_8kv.Maximum = 100;
            this.Trans_8kv.Name = "Trans_8kv";
            this.Trans_8kv.Size = new System.Drawing.Size(245, 23);
            this.Trans_8kv.TabIndex = 14;
            this.Trans_8kv.TickFrequency = 10;
            this.Trans_8kv.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Trans_8kv.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(4, 173);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(44, 31);
            this.label30.TabIndex = 21;
            this.label30.Text = "2 kHz";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(4, 142);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(44, 31);
            this.label31.TabIndex = 20;
            this.label31.Text = "1 kHz";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(4, 111);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 31);
            this.label32.TabIndex = 19;
            this.label32.Text = "500 Hz";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Trans_4k_Out
            // 
            this.Trans_4k_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trans_4k_Out.Enabled = false;
            this.Trans_4k_Out.Location = new System.Drawing.Point(390, 208);
            this.Trans_4k_Out.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_4k_Out.Name = "Trans_4k_Out";
            this.Trans_4k_Out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Trans_4k_Out.Size = new System.Drawing.Size(72, 22);
            this.Trans_4k_Out.TabIndex = 44;
            this.Trans_4k_Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Trans_4k_Out.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Trans_4kv
            // 
            this.Trans_4kv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trans_4kv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Trans_4kv.Enabled = false;
            this.Trans_4kv.LargeChange = 10;
            this.Trans_4kv.Location = new System.Drawing.Point(137, 208);
            this.Trans_4kv.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_4kv.Maximum = 100;
            this.Trans_4kv.Name = "Trans_4kv";
            this.Trans_4kv.Size = new System.Drawing.Size(245, 23);
            this.Trans_4kv.TabIndex = 12;
            this.Trans_4kv.TickFrequency = 10;
            this.Trans_4kv.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Trans_4kv.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(4, 80);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(53, 31);
            this.label33.TabIndex = 25;
            this.label33.Text = "250 Hz";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(4, 49);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(53, 31);
            this.label34.TabIndex = 18;
            this.label34.Text = "125 Hz";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Trans_2k_Out
            // 
            this.Trans_2k_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trans_2k_Out.Enabled = false;
            this.Trans_2k_Out.Location = new System.Drawing.Point(390, 177);
            this.Trans_2k_Out.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_2k_Out.Name = "Trans_2k_Out";
            this.Trans_2k_Out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Trans_2k_Out.Size = new System.Drawing.Size(72, 22);
            this.Trans_2k_Out.TabIndex = 43;
            this.Trans_2k_Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Trans_2k_Out.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(4, 18);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(57, 31);
            this.label35.TabIndex = 17;
            this.label35.Text = "62.5 Hz";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Trans_2kv
            // 
            this.Trans_2kv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trans_2kv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Trans_2kv.Enabled = false;
            this.Trans_2kv.LargeChange = 10;
            this.Trans_2kv.Location = new System.Drawing.Point(137, 177);
            this.Trans_2kv.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_2kv.Maximum = 100;
            this.Trans_2kv.Name = "Trans_2kv";
            this.Trans_2kv.Size = new System.Drawing.Size(245, 23);
            this.Trans_2kv.TabIndex = 11;
            this.Trans_2kv.TickFrequency = 10;
            this.Trans_2kv.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Trans_2kv.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // label36
            // 
            this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label36.AutoSize = true;
            this.tableLayoutPanel6.SetColumnSpan(this.label36, 3);
            this.label36.Location = new System.Drawing.Point(4, 1);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(414, 17);
            this.label36.TabIndex = 30;
            this.label36.Text = "Transmission Coefficients (%  non-absorbed transmitted energy)";
            // 
            // Trans_63v
            // 
            this.Trans_63v.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trans_63v.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Trans_63v.Enabled = false;
            this.Trans_63v.LargeChange = 10;
            this.Trans_63v.Location = new System.Drawing.Point(137, 22);
            this.Trans_63v.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_63v.Maximum = 100;
            this.Trans_63v.Name = "Trans_63v";
            this.Trans_63v.Size = new System.Drawing.Size(245, 23);
            this.Trans_63v.TabIndex = 16;
            this.Trans_63v.TickFrequency = 10;
            this.Trans_63v.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Trans_63v.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Trans_63_Out
            // 
            this.Trans_63_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trans_63_Out.Enabled = false;
            this.Trans_63_Out.Location = new System.Drawing.Point(390, 22);
            this.Trans_63_Out.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_63_Out.Name = "Trans_63_Out";
            this.Trans_63_Out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Trans_63_Out.Size = new System.Drawing.Size(72, 22);
            this.Trans_63_Out.TabIndex = 38;
            this.Trans_63_Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Trans_63_Out.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Trans_1k_Out
            // 
            this.Trans_1k_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trans_1k_Out.Enabled = false;
            this.Trans_1k_Out.Location = new System.Drawing.Point(390, 146);
            this.Trans_1k_Out.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_1k_Out.Name = "Trans_1k_Out";
            this.Trans_1k_Out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Trans_1k_Out.Size = new System.Drawing.Size(72, 22);
            this.Trans_1k_Out.TabIndex = 42;
            this.Trans_1k_Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Trans_1k_Out.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Trans_1kv
            // 
            this.Trans_1kv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trans_1kv.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Trans_1kv.Enabled = false;
            this.Trans_1kv.LargeChange = 10;
            this.Trans_1kv.Location = new System.Drawing.Point(137, 146);
            this.Trans_1kv.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_1kv.Maximum = 100;
            this.Trans_1kv.Name = "Trans_1kv";
            this.Trans_1kv.Size = new System.Drawing.Size(245, 23);
            this.Trans_1kv.TabIndex = 10;
            this.Trans_1kv.TickFrequency = 10;
            this.Trans_1kv.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Trans_1kv.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Trans_125_Out
            // 
            this.Trans_125_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trans_125_Out.Enabled = false;
            this.Trans_125_Out.Location = new System.Drawing.Point(390, 53);
            this.Trans_125_Out.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_125_Out.Name = "Trans_125_Out";
            this.Trans_125_Out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Trans_125_Out.Size = new System.Drawing.Size(72, 22);
            this.Trans_125_Out.TabIndex = 39;
            this.Trans_125_Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Trans_125_Out.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Trans_125v
            // 
            this.Trans_125v.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trans_125v.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Trans_125v.Enabled = false;
            this.Trans_125v.LargeChange = 10;
            this.Trans_125v.Location = new System.Drawing.Point(137, 53);
            this.Trans_125v.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_125v.Maximum = 100;
            this.Trans_125v.Name = "Trans_125v";
            this.Trans_125v.Size = new System.Drawing.Size(245, 23);
            this.Trans_125v.TabIndex = 15;
            this.Trans_125v.TickFrequency = 10;
            this.Trans_125v.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Trans_125v.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Trans_500_Out
            // 
            this.Trans_500_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trans_500_Out.Enabled = false;
            this.Trans_500_Out.Location = new System.Drawing.Point(390, 115);
            this.Trans_500_Out.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_500_Out.Name = "Trans_500_Out";
            this.Trans_500_Out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Trans_500_Out.Size = new System.Drawing.Size(72, 22);
            this.Trans_500_Out.TabIndex = 41;
            this.Trans_500_Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Trans_500_Out.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Trans_250v
            // 
            this.Trans_250v.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trans_250v.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Trans_250v.Enabled = false;
            this.Trans_250v.LargeChange = 10;
            this.Trans_250v.Location = new System.Drawing.Point(137, 84);
            this.Trans_250v.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_250v.Maximum = 100;
            this.Trans_250v.Name = "Trans_250v";
            this.Trans_250v.Size = new System.Drawing.Size(245, 23);
            this.Trans_250v.TabIndex = 9;
            this.Trans_250v.TickFrequency = 10;
            this.Trans_250v.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Trans_250v.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Trans_500v
            // 
            this.Trans_500v.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trans_500v.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Trans_500v.Enabled = false;
            this.Trans_500v.LargeChange = 10;
            this.Trans_500v.Location = new System.Drawing.Point(137, 115);
            this.Trans_500v.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_500v.Maximum = 100;
            this.Trans_500v.Name = "Trans_500v";
            this.Trans_500v.Size = new System.Drawing.Size(245, 23);
            this.Trans_500v.TabIndex = 13;
            this.Trans_500v.TickFrequency = 10;
            this.Trans_500v.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Trans_500v.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Trans_250_Out
            // 
            this.Trans_250_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Trans_250_Out.Enabled = false;
            this.Trans_250_Out.Location = new System.Drawing.Point(390, 84);
            this.Trans_250_Out.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_250_Out.Name = "Trans_250_Out";
            this.Trans_250_Out.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Trans_250_Out.Size = new System.Drawing.Size(72, 22);
            this.Trans_250_Out.TabIndex = 40;
            this.Trans_250_Out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Trans_250_Out.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // Trans_Check
            // 
            this.Trans_Check.AutoSize = true;
            this.Trans_Check.Dock = System.Windows.Forms.DockStyle.Top;
            this.Trans_Check.Location = new System.Drawing.Point(137, 301);
            this.Trans_Check.Margin = new System.Windows.Forms.Padding(4);
            this.Trans_Check.Name = "Trans_Check";
            this.Trans_Check.Size = new System.Drawing.Size(245, 21);
            this.Trans_Check.TabIndex = 46;
            this.Trans_Check.Text = "Semi-Transparent Material";
            this.Trans_Check.UseVisualStyleBackColor = true;
            this.Trans_Check.CheckedChanged += new System.EventHandler(this.Trans_Check_CheckedChanged);
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(4, 235);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 31);
            this.label28.TabIndex = 24;
            this.label28.Text = "8 kHz";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 266);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 31);
            this.label23.TabIndex = 38;
            this.label23.Text = "Flatten All";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel8);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(493, 598);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Transmission Loss";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel8.Controls.Add(this.label64, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.Isolation_Lib, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label63, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label53, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.TL_Check, 1, 11);
            this.tableLayoutPanel8.Controls.Add(this.TL8k, 1, 10);
            this.tableLayoutPanel8.Controls.Add(this.label54, 0, 10);
            this.tableLayoutPanel8.Controls.Add(this.label52, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.label51, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.label48, 0, 7);
            this.tableLayoutPanel8.Controls.Add(this.label46, 0, 9);
            this.tableLayoutPanel8.Controls.Add(this.label47, 0, 8);
            this.tableLayoutPanel8.Controls.Add(this.label49, 0, 6);
            this.tableLayoutPanel8.Controls.Add(this.label50, 0, 5);
            this.tableLayoutPanel8.Controls.Add(this.TL4k, 1, 9);
            this.tableLayoutPanel8.Controls.Add(this.TL2k, 1, 8);
            this.tableLayoutPanel8.Controls.Add(this.TL1k, 1, 7);
            this.tableLayoutPanel8.Controls.Add(this.TL500, 1, 6);
            this.tableLayoutPanel8.Controls.Add(this.TL250, 1, 5);
            this.tableLayoutPanel8.Controls.Add(this.TL125, 1, 4);
            this.tableLayoutPanel8.Controls.Add(this.TL63, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.label55, 2, 4);
            this.tableLayoutPanel8.Controls.Add(this.label56, 2, 3);
            this.tableLayoutPanel8.Controls.Add(this.label57, 2, 5);
            this.tableLayoutPanel8.Controls.Add(this.label58, 2, 6);
            this.tableLayoutPanel8.Controls.Add(this.label59, 2, 7);
            this.tableLayoutPanel8.Controls.Add(this.label60, 2, 8);
            this.tableLayoutPanel8.Controls.Add(this.label61, 2, 9);
            this.tableLayoutPanel8.Controls.Add(this.label62, 2, 10);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 12;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(487, 592);
            this.tableLayoutPanel8.TabIndex = 48;
            // 
            // Isolation_Lib
            // 
            this.Isolation_Lib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Isolation_Lib.FormattingEnabled = true;
            this.Isolation_Lib.ItemHeight = 16;
            this.Isolation_Lib.Location = new System.Drawing.Point(4, 26);
            this.Isolation_Lib.Margin = new System.Windows.Forms.Padding(4);
            this.Isolation_Lib.Name = "Isolation_Lib";
            this.Isolation_Lib.ScrollAlwaysVisible = true;
            this.Isolation_Lib.Size = new System.Drawing.Size(164, 111);
            this.Isolation_Lib.TabIndex = 50;
            this.Isolation_Lib.Click += new System.EventHandler(this.Isolation_Lib_SelectedIndexChanged);
            this.Isolation_Lib.SelectedIndexChanged += new System.EventHandler(this.Isolation_Lib_SelectedIndexChanged);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(4, 0);
            this.label63.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(144, 17);
            this.label63.TabIndex = 49;
            this.label63.Text = "Transmission Library:";
            // 
            // groupBox1
            // 
            this.tableLayoutPanel8.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.DeleteAssembly);
            this.groupBox1.Controls.Add(this.SaveAssembly);
            this.groupBox1.Controls.Add(this.IsolationAssemblies);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(176, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel8.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(307, 133);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save Assembly Transmission Loss";
            // 
            // DeleteAssembly
            // 
            this.DeleteAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteAssembly.Location = new System.Drawing.Point(8, 90);
            this.DeleteAssembly.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteAssembly.Name = "DeleteAssembly";
            this.DeleteAssembly.Size = new System.Drawing.Size(291, 28);
            this.DeleteAssembly.TabIndex = 2;
            this.DeleteAssembly.Text = "Delete Assembly";
            this.DeleteAssembly.UseVisualStyleBackColor = true;
            this.DeleteAssembly.Click += new System.EventHandler(this.Delete_Isolation_Click);
            // 
            // SaveAssembly
            // 
            this.SaveAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveAssembly.Location = new System.Drawing.Point(8, 54);
            this.SaveAssembly.Margin = new System.Windows.Forms.Padding(4);
            this.SaveAssembly.Name = "SaveAssembly";
            this.SaveAssembly.Size = new System.Drawing.Size(291, 28);
            this.SaveAssembly.TabIndex = 1;
            this.SaveAssembly.Text = "Save Assembly";
            this.SaveAssembly.UseVisualStyleBackColor = true;
            this.SaveAssembly.Click += new System.EventHandler(this.SaveIso_Click);
            // 
            // IsolationAssemblies
            // 
            this.IsolationAssemblies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IsolationAssemblies.Location = new System.Drawing.Point(8, 22);
            this.IsolationAssemblies.Margin = new System.Windows.Forms.Padding(4);
            this.IsolationAssemblies.Name = "IsolationAssemblies";
            this.IsolationAssemblies.Size = new System.Drawing.Size(290, 22);
            this.IsolationAssemblies.TabIndex = 0;
            // 
            // label53
            // 
            this.label53.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label53.AutoSize = true;
            this.tableLayoutPanel8.SetColumnSpan(this.label53, 2);
            this.label53.Location = new System.Drawing.Point(4, 141);
            this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(218, 17);
            this.label53.TabIndex = 30;
            this.label53.Text = "Transmission Loss (decibels lost)";
            // 
            // TL_Check
            // 
            this.TL_Check.AutoSize = true;
            this.TL_Check.Dock = System.Windows.Forms.DockStyle.Top;
            this.TL_Check.Location = new System.Drawing.Point(176, 410);
            this.TL_Check.Margin = new System.Windows.Forms.Padding(4);
            this.TL_Check.Name = "TL_Check";
            this.TL_Check.Size = new System.Drawing.Size(177, 21);
            this.TL_Check.TabIndex = 46;
            this.TL_Check.Text = "Transmissive Assembly";
            this.TL_Check.UseVisualStyleBackColor = true;
            this.TL_Check.CheckedChanged += new System.EventHandler(this.Trans_Check_CheckedChanged);
            // 
            // TL8k
            // 
            this.TL8k.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TL8k.DecimalPlaces = 2;
            this.TL8k.Enabled = false;
            this.TL8k.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TL8k.Location = new System.Drawing.Point(176, 379);
            this.TL8k.Margin = new System.Windows.Forms.Padding(4);
            this.TL8k.Name = "TL8k";
            this.TL8k.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TL8k.Size = new System.Drawing.Size(177, 22);
            this.TL8k.TabIndex = 45;
            this.TL8k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TL8k.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // label54
            // 
            this.label54.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(4, 375);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(44, 31);
            this.label54.TabIndex = 24;
            this.label54.Text = "8 kHz";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label52
            // 
            this.label52.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(4, 158);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(57, 31);
            this.label52.TabIndex = 17;
            this.label52.Text = "62.5 Hz";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label51
            // 
            this.label51.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(4, 189);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(53, 31);
            this.label51.TabIndex = 18;
            this.label51.Text = "125 Hz";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label48
            // 
            this.label48.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(4, 282);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(44, 31);
            this.label48.TabIndex = 20;
            this.label48.Text = "1 kHz";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label46
            // 
            this.label46.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(4, 344);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(44, 31);
            this.label46.TabIndex = 22;
            this.label46.Text = "4 kHz";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label47
            // 
            this.label47.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(4, 313);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(44, 31);
            this.label47.TabIndex = 21;
            this.label47.Text = "2 kHz";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label49
            // 
            this.label49.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(4, 251);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(53, 31);
            this.label49.TabIndex = 19;
            this.label49.Text = "500 Hz";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label50
            // 
            this.label50.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(4, 220);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(53, 31);
            this.label50.TabIndex = 25;
            this.label50.Text = "250 Hz";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TL4k
            // 
            this.TL4k.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TL4k.DecimalPlaces = 2;
            this.TL4k.Enabled = false;
            this.TL4k.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TL4k.Location = new System.Drawing.Point(176, 348);
            this.TL4k.Margin = new System.Windows.Forms.Padding(4);
            this.TL4k.Name = "TL4k";
            this.TL4k.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TL4k.Size = new System.Drawing.Size(177, 22);
            this.TL4k.TabIndex = 44;
            this.TL4k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TL4k.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // TL2k
            // 
            this.TL2k.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TL2k.DecimalPlaces = 2;
            this.TL2k.Enabled = false;
            this.TL2k.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TL2k.Location = new System.Drawing.Point(176, 317);
            this.TL2k.Margin = new System.Windows.Forms.Padding(4);
            this.TL2k.Name = "TL2k";
            this.TL2k.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TL2k.Size = new System.Drawing.Size(177, 22);
            this.TL2k.TabIndex = 43;
            this.TL2k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TL2k.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // TL1k
            // 
            this.TL1k.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TL1k.DecimalPlaces = 2;
            this.TL1k.Enabled = false;
            this.TL1k.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TL1k.Location = new System.Drawing.Point(176, 286);
            this.TL1k.Margin = new System.Windows.Forms.Padding(4);
            this.TL1k.Name = "TL1k";
            this.TL1k.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TL1k.Size = new System.Drawing.Size(177, 22);
            this.TL1k.TabIndex = 42;
            this.TL1k.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TL1k.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // TL500
            // 
            this.TL500.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TL500.DecimalPlaces = 2;
            this.TL500.Enabled = false;
            this.TL500.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TL500.Location = new System.Drawing.Point(176, 255);
            this.TL500.Margin = new System.Windows.Forms.Padding(4);
            this.TL500.Name = "TL500";
            this.TL500.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TL500.Size = new System.Drawing.Size(177, 22);
            this.TL500.TabIndex = 41;
            this.TL500.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TL500.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // TL250
            // 
            this.TL250.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TL250.DecimalPlaces = 2;
            this.TL250.Enabled = false;
            this.TL250.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TL250.Location = new System.Drawing.Point(176, 224);
            this.TL250.Margin = new System.Windows.Forms.Padding(4);
            this.TL250.Name = "TL250";
            this.TL250.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TL250.Size = new System.Drawing.Size(177, 22);
            this.TL250.TabIndex = 40;
            this.TL250.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TL250.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // TL125
            // 
            this.TL125.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TL125.DecimalPlaces = 2;
            this.TL125.Enabled = false;
            this.TL125.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TL125.Location = new System.Drawing.Point(176, 193);
            this.TL125.Margin = new System.Windows.Forms.Padding(4);
            this.TL125.Name = "TL125";
            this.TL125.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TL125.Size = new System.Drawing.Size(177, 22);
            this.TL125.TabIndex = 39;
            this.TL125.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TL125.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // TL63
            // 
            this.TL63.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TL63.DecimalPlaces = 2;
            this.TL63.Enabled = false;
            this.TL63.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TL63.Location = new System.Drawing.Point(176, 162);
            this.TL63.Margin = new System.Windows.Forms.Padding(4);
            this.TL63.Name = "TL63";
            this.TL63.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TL63.Size = new System.Drawing.Size(177, 22);
            this.TL63.TabIndex = 38;
            this.TL63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TL63.ValueChanged += new System.EventHandler(this.Acoustics_Coef_Update);
            // 
            // label55
            // 
            this.label55.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(360, 196);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(60, 17);
            this.label55.TabIndex = 47;
            this.label55.Text = "decibels";
            // 
            // label56
            // 
            this.label56.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(360, 165);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(60, 17);
            this.label56.TabIndex = 47;
            this.label56.Text = "decibels";
            // 
            // label57
            // 
            this.label57.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(360, 227);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(60, 17);
            this.label57.TabIndex = 47;
            this.label57.Text = "decibels";
            // 
            // label58
            // 
            this.label58.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(360, 258);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(60, 17);
            this.label58.TabIndex = 47;
            this.label58.Text = "decibels";
            // 
            // label59
            // 
            this.label59.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(360, 289);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(60, 17);
            this.label59.TabIndex = 47;
            this.label59.Text = "decibels";
            // 
            // label60
            // 
            this.label60.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(360, 320);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(60, 17);
            this.label60.TabIndex = 47;
            this.label60.Text = "decibels";
            // 
            // label61
            // 
            this.label61.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(360, 351);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(60, 17);
            this.label61.TabIndex = 47;
            this.label61.Text = "decibels";
            // 
            // label62
            // 
            this.label62.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(360, 382);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(60, 17);
            this.label62.TabIndex = 47;
            this.label62.Text = "decibels";
            // 
            // LayerDisplay
            // 
            this.LayerDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayerDisplay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LayerDisplay.FormattingEnabled = true;
            this.LayerDisplay.Location = new System.Drawing.Point(166, 4);
            this.LayerDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.LayerDisplay.MaxDropDownItems = 100;
            this.LayerDisplay.Name = "LayerDisplay";
            this.LayerDisplay.Size = new System.Drawing.Size(347, 24);
            this.LayerDisplay.TabIndex = 27;
            this.LayerDisplay.SelectedValueChanged += new System.EventHandler(this.Retrieve_Layer_Acoustics);
            // 
            // TabPage3
            // 
            this.TabPage3.AutoScroll = true;
            this.TabPage3.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.TabPage3.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.TabPage3.Controls.Add(this.tableLayoutPanel3);
            this.TabPage3.Location = new System.Drawing.Point(4, 25);
            this.TabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.TabPage3.Size = new System.Drawing.Size(525, 705);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Analysis";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.72973F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.27027F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel3.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label25, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.SourceList, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Source_Aim, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.GroupBox3, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label27, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.Receiver_Choice, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.Analysis_View, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.label26, 5, 3);
            this.tableLayoutPanel3.Controls.Add(this.Normalize_Graph, 5, 7);
            this.tableLayoutPanel3.Controls.Add(this.Alt_Choice, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.LockUserScale, 3, 7);
            this.tableLayoutPanel3.Controls.Add(this.Azi_Choice, 6, 3);
            this.tableLayoutPanel3.Controls.Add(this.Graph_Type, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.Auralisation, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.Label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.Graph_Octave, 4, 6);
            this.tableLayoutPanel3.Controls.Add(this.IS_Path_Box, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.PathCount, 6, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 10;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(517, 697);
            this.tableLayoutPanel3.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(4, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 17);
            this.label15.TabIndex = 45;
            this.label15.Text = "Source";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label25, 2);
            this.label25.Enabled = false;
            this.label25.Location = new System.Drawing.Point(4, 169);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(98, 17);
            this.label25.TabIndex = 46;
            this.label25.Text = "Aim at Source";
            // 
            // SourceList
            // 
            this.SourceList.CheckOnClick = true;
            this.tableLayoutPanel3.SetColumnSpan(this.SourceList, 3);
            this.SourceList.ContextMenuStrip = this.SourceContext;
            this.SourceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SourceList.FormattingEnabled = true;
            this.SourceList.Location = new System.Drawing.Point(4, 23);
            this.SourceList.Margin = new System.Windows.Forms.Padding(4);
            this.SourceList.MinimumSize = new System.Drawing.Size(4, 78);
            this.SourceList.Name = "SourceList";
            this.SourceList.ScrollAlwaysVisible = true;
            this.SourceList.Size = new System.Drawing.Size(208, 112);
            this.SourceList.TabIndex = 44;
            this.SourceList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SourceList_MouseUp);
            // 
            // SourceContext
            // 
            this.SourceContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SourceContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PowerMod,
            this.DelayMod});
            this.SourceContext.Name = "contextMenuStrip1";
            this.SourceContext.Size = new System.Drawing.Size(219, 52);
            // 
            // PowerMod
            // 
            this.PowerMod.Name = "PowerMod";
            this.PowerMod.Size = new System.Drawing.Size(218, 24);
            this.PowerMod.Text = "Modify Source Power";
            this.PowerMod.Click += new System.EventHandler(this.Source_Power_Mod_Click);
            // 
            // DelayMod
            // 
            this.DelayMod.Name = "DelayMod";
            this.DelayMod.Size = new System.Drawing.Size(218, 24);
            this.DelayMod.Text = "Modify Source Delay";
            this.DelayMod.Click += new System.EventHandler(this.DelayMod_Click);
            // 
            // Source_Aim
            // 
            this.Source_Aim.FormattingEnabled = true;
            this.Source_Aim.Location = new System.Drawing.Point(110, 173);
            this.Source_Aim.Margin = new System.Windows.Forms.Padding(4);
            this.Source_Aim.Name = "Source_Aim";
            this.Source_Aim.Size = new System.Drawing.Size(69, 24);
            this.Source_Aim.TabIndex = 51;
            this.Source_Aim.Text = "None";
            this.Source_Aim.SelectedIndexChanged += new System.EventHandler(this.Source_Aim_SelectedIndexChanged);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.GroupBox3, 4);
            this.GroupBox3.Controls.Add(this.tableLayoutPanel1);
            this.GroupBox3.Location = new System.Drawing.Point(220, 4);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.SetRowSpan(this.GroupBox3, 3);
            this.GroupBox3.Size = new System.Drawing.Size(293, 161);
            this.GroupBox3.TabIndex = 6;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Parametric Analysis";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SRT8, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Parameter_Choice, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SRT7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.SRT6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SRT2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SRT5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SRT3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SRT4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.SRT1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ISOCOMP, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(285, 138);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // SRT8
            // 
            this.SRT8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SRT8.AutoSize = true;
            this.SRT8.Location = new System.Drawing.Point(146, 113);
            this.SRT8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SRT8.Name = "SRT8";
            this.SRT8.Size = new System.Drawing.Size(135, 25);
            this.SRT8.TabIndex = 15;
            this.SRT8.Text = "8000 hz:";
            // 
            // Parameter_Choice
            // 
            this.Parameter_Choice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Parameter_Choice.FormattingEnabled = true;
            this.Parameter_Choice.Items.AddRange(new object[] {
            "Early Decay Time",
            "T-15",
            "T-30",
            "Center Time (TS)",
            "Clarity (C-50)",
            "Clarity (C-80)",
            "Definition (D-50)",
            "Strength/Loudness (G)",
            "Sound Pressure Level (SPL)",
            "Initial Time Delay Gap (ITDG)",
            "Speech Transmission Index (Explicit)",
            "Modulation Transfer Index (MTI - root STI)",
            "Lateral Fraction (LF)",
            "Lateral Efficiency (LE)",
            "Echo Criterion (Music, 10%)",
            "Echo Criterion (Music, 50%)",
            "Echo Criterion (Speech, 10%)",
            "Echo Criterion (Speech, 50%)"});
            this.Parameter_Choice.Location = new System.Drawing.Point(4, 4);
            this.Parameter_Choice.Margin = new System.Windows.Forms.Padding(4);
            this.Parameter_Choice.Name = "Parameter_Choice";
            this.Parameter_Choice.Size = new System.Drawing.Size(134, 24);
            this.Parameter_Choice.TabIndex = 27;
            this.Parameter_Choice.Text = "Select Parameter...";
            this.Parameter_Choice.TextChanged += new System.EventHandler(this.Parameter_Choice_SelectedIndexChanged);
            // 
            // SRT7
            // 
            this.SRT7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SRT7.AutoSize = true;
            this.SRT7.Location = new System.Drawing.Point(146, 88);
            this.SRT7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SRT7.Name = "SRT7";
            this.SRT7.Size = new System.Drawing.Size(135, 25);
            this.SRT7.TabIndex = 14;
            this.SRT7.Text = "4000 hz:";
            // 
            // SRT6
            // 
            this.SRT6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SRT6.AutoSize = true;
            this.SRT6.Location = new System.Drawing.Point(146, 63);
            this.SRT6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SRT6.Name = "SRT6";
            this.SRT6.Size = new System.Drawing.Size(135, 25);
            this.SRT6.TabIndex = 13;
            this.SRT6.Text = "2000 hz:";
            // 
            // SRT2
            // 
            this.SRT2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SRT2.AutoSize = true;
            this.SRT2.Location = new System.Drawing.Point(4, 63);
            this.SRT2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SRT2.Name = "SRT2";
            this.SRT2.Size = new System.Drawing.Size(134, 25);
            this.SRT2.TabIndex = 9;
            this.SRT2.Text = "125 hz:";
            // 
            // SRT5
            // 
            this.SRT5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SRT5.AutoSize = true;
            this.SRT5.Location = new System.Drawing.Point(146, 38);
            this.SRT5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SRT5.Name = "SRT5";
            this.SRT5.Size = new System.Drawing.Size(135, 25);
            this.SRT5.TabIndex = 12;
            this.SRT5.Text = "1000 hz:";
            // 
            // SRT3
            // 
            this.SRT3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SRT3.AutoSize = true;
            this.SRT3.Location = new System.Drawing.Point(4, 88);
            this.SRT3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SRT3.Name = "SRT3";
            this.SRT3.Size = new System.Drawing.Size(134, 25);
            this.SRT3.TabIndex = 10;
            this.SRT3.Text = "250 hz:";
            // 
            // SRT4
            // 
            this.SRT4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SRT4.AutoSize = true;
            this.SRT4.Location = new System.Drawing.Point(4, 113);
            this.SRT4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SRT4.Name = "SRT4";
            this.SRT4.Size = new System.Drawing.Size(134, 25);
            this.SRT4.TabIndex = 11;
            this.SRT4.Text = "500 hz:";
            // 
            // SRT1
            // 
            this.SRT1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SRT1.AutoSize = true;
            this.SRT1.Location = new System.Drawing.Point(4, 38);
            this.SRT1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SRT1.Name = "SRT1";
            this.SRT1.Size = new System.Drawing.Size(134, 25);
            this.SRT1.TabIndex = 8;
            this.SRT1.Text = "62.5 hz:";
            // 
            // ISOCOMP
            // 
            this.ISOCOMP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ISOCOMP.AutoSize = true;
            this.ISOCOMP.Location = new System.Drawing.Point(162, 10);
            this.ISOCOMP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ISOCOMP.Name = "ISOCOMP";
            this.ISOCOMP.Size = new System.Drawing.Size(102, 17);
            this.ISOCOMP.TabIndex = 28;
            this.ISOCOMP.Text = "ISO-Compliant:";
            this.ISOCOMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Enabled = false;
            this.label20.Location = new System.Drawing.Point(4, 139);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 17);
            this.label20.TabIndex = 40;
            this.label20.Text = "Receiver";
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Enabled = false;
            this.label27.Location = new System.Drawing.Point(220, 169);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(25, 30);
            this.label27.TabIndex = 50;
            this.label27.Text = "Altitude";
            // 
            // Receiver_Choice
            // 
            this.Receiver_Choice.FormattingEnabled = true;
            this.Receiver_Choice.Location = new System.Drawing.Point(110, 143);
            this.Receiver_Choice.Margin = new System.Windows.Forms.Padding(4);
            this.Receiver_Choice.Name = "Receiver_Choice";
            this.Receiver_Choice.Size = new System.Drawing.Size(102, 24);
            this.Receiver_Choice.TabIndex = 39;
            this.Receiver_Choice.Text = "No Results Calculated...";
            this.Receiver_Choice.SelectedIndexChanged += new System.EventHandler(this.Receiver_Choice_SelectedIndexChanged);
            // 
            // Analysis_View
            // 
            this.Analysis_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Analysis_View.AutoSize = true;
            this.Analysis_View.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.SetColumnSpan(this.Analysis_View, 7);
            this.Analysis_View.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.Analysis_View.Location = new System.Drawing.Point(8, 368);
            this.Analysis_View.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Analysis_View.Name = "Analysis_View";
            this.Analysis_View.PanModifierKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.None)));
            this.Analysis_View.ScrollGrace = 0D;
            this.Analysis_View.ScrollMaxX = 0D;
            this.Analysis_View.ScrollMaxY = 0D;
            this.Analysis_View.ScrollMaxY2 = 0D;
            this.Analysis_View.ScrollMinX = 0D;
            this.Analysis_View.ScrollMinY = 0D;
            this.Analysis_View.ScrollMinY2 = 0D;
            this.Analysis_View.Size = new System.Drawing.Size(501, 290);
            this.Analysis_View.TabIndex = 42;
            this.Analysis_View.UseExtendedPrintDialog = true;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Enabled = false;
            this.label26.Location = new System.Drawing.Point(352, 169);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(25, 30);
            this.label26.TabIndex = 49;
            this.label26.Text = "Azimuth";
            // 
            // Normalize_Graph
            // 
            this.Normalize_Graph.AutoSize = true;
            this.Normalize_Graph.Checked = true;
            this.Normalize_Graph.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel3.SetColumnSpan(this.Normalize_Graph, 2);
            this.Normalize_Graph.Location = new System.Drawing.Point(352, 337);
            this.Normalize_Graph.Margin = new System.Windows.Forms.Padding(4);
            this.Normalize_Graph.Name = "Normalize_Graph";
            this.Normalize_Graph.Size = new System.Drawing.Size(155, 20);
            this.Normalize_Graph.TabIndex = 43;
            this.Normalize_Graph.Text = "Normalize To Direct";
            this.Normalize_Graph.UseVisualStyleBackColor = true;
            this.Normalize_Graph.CheckedChanged += new System.EventHandler(this.Normalize_Graph_CheckedChanged);
            // 
            // Alt_Choice
            // 
            this.Alt_Choice.DecimalPlaces = 2;
            this.Alt_Choice.Location = new System.Drawing.Point(253, 173);
            this.Alt_Choice.Margin = new System.Windows.Forms.Padding(4);
            this.Alt_Choice.Maximum = new decimal(new int[] {
            91,
            0,
            0,
            0});
            this.Alt_Choice.Minimum = new decimal(new int[] {
            91,
            0,
            0,
            -2147483648});
            this.Alt_Choice.Name = "Alt_Choice";
            this.Alt_Choice.Size = new System.Drawing.Size(80, 22);
            this.Alt_Choice.TabIndex = 48;
            this.Alt_Choice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Alt_Choice.ValueChanged += new System.EventHandler(this.Alt_Choice_ValueChanged);
            // 
            // LockUserScale
            // 
            this.LockUserScale.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.LockUserScale, 2);
            this.LockUserScale.Location = new System.Drawing.Point(220, 337);
            this.LockUserScale.Margin = new System.Windows.Forms.Padding(4);
            this.LockUserScale.Name = "LockUserScale";
            this.LockUserScale.Size = new System.Drawing.Size(124, 20);
            this.LockUserScale.TabIndex = 44;
            this.LockUserScale.Text = "Lock User Scale";
            this.LockUserScale.UseVisualStyleBackColor = true;
            this.LockUserScale.CheckedChanged += new System.EventHandler(this.Update_Graph);
            // 
            // Azi_Choice
            // 
            this.Azi_Choice.DecimalPlaces = 2;
            this.Azi_Choice.Location = new System.Drawing.Point(385, 173);
            this.Azi_Choice.Margin = new System.Windows.Forms.Padding(4);
            this.Azi_Choice.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.Azi_Choice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Azi_Choice.Name = "Azi_Choice";
            this.Azi_Choice.Size = new System.Drawing.Size(80, 22);
            this.Azi_Choice.TabIndex = 47;
            this.Azi_Choice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Azi_Choice.ValueChanged += new System.EventHandler(this.Azi_Choice_ValueChanged);
            // 
            // Graph_Type
            // 
            this.Graph_Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.Graph_Type, 4);
            this.Graph_Type.FormattingEnabled = true;
            this.Graph_Type.Items.AddRange(new object[] {
            "Energy Time Curve",
            "Pressure Time Curve",
            "Lateral ETC",
            "Lateral PTC",
            "Vertical ETC",
            "Vertical PTC",
            "Fore-Aft ETC",
            "Fore-Aft PTC"});
            this.Graph_Type.Location = new System.Drawing.Point(4, 309);
            this.Graph_Type.Margin = new System.Windows.Forms.Padding(4);
            this.Graph_Type.Name = "Graph_Type";
            this.Graph_Type.Size = new System.Drawing.Size(241, 24);
            this.Graph_Type.TabIndex = 33;
            this.Graph_Type.Text = "Energy Time Curve";
            this.Graph_Type.TextChanged += new System.EventHandler(this.Update_Graph);
            // 
            // Auralisation
            // 
            this.Auralisation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.Auralisation, 7);
            this.Auralisation.Location = new System.Drawing.Point(4, 669);
            this.Auralisation.Margin = new System.Windows.Forms.Padding(4);
            this.Auralisation.Name = "Auralisation";
            this.Auralisation.Size = new System.Drawing.Size(509, 24);
            this.Auralisation.TabIndex = 45;
            this.Auralisation.Text = "Go To Auralizations";
            this.Auralisation.UseVisualStyleBackColor = true;
            this.Auralisation.Click += new System.EventHandler(this.Auralisation_Click);
            // 
            // Label5
            // 
            this.Label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label5.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.Label5, 4);
            this.Label5.Enabled = false;
            this.Label5.Location = new System.Drawing.Point(4, 199);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(241, 17);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "Image Source Paths";
            // 
            // Graph_Octave
            // 
            this.Graph_Octave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.Graph_Octave, 3);
            this.Graph_Octave.FormattingEnabled = true;
            this.Graph_Octave.Items.AddRange(new object[] {
            "Summation: All Octaves",
            "62.5 Hz.",
            "125 Hz.",
            "250 Hz.",
            "500 Hz.",
            "1 kHz.",
            "2 kHz.",
            "4 kHz.",
            "8 kHz."});
            this.Graph_Octave.Location = new System.Drawing.Point(253, 309);
            this.Graph_Octave.Margin = new System.Windows.Forms.Padding(4);
            this.Graph_Octave.Name = "Graph_Octave";
            this.Graph_Octave.Size = new System.Drawing.Size(260, 24);
            this.Graph_Octave.TabIndex = 33;
            this.Graph_Octave.Text = "Summation: All Octaves";
            this.Graph_Octave.TextChanged += new System.EventHandler(this.Update_Graph);
            // 
            // IS_Path_Box
            // 
            this.IS_Path_Box.CheckOnClick = true;
            this.tableLayoutPanel3.SetColumnSpan(this.IS_Path_Box, 7);
            this.IS_Path_Box.ContextMenuStrip = this.PathContext;
            this.IS_Path_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IS_Path_Box.FormattingEnabled = true;
            this.IS_Path_Box.Location = new System.Drawing.Point(4, 224);
            this.IS_Path_Box.Margin = new System.Windows.Forms.Padding(4);
            this.IS_Path_Box.MinimumSize = new System.Drawing.Size(4, 78);
            this.IS_Path_Box.Name = "IS_Path_Box";
            this.IS_Path_Box.ScrollAlwaysVisible = true;
            this.IS_Path_Box.Size = new System.Drawing.Size(509, 78);
            this.IS_Path_Box.TabIndex = 7;
            this.IS_Path_Box.MouseUp += new System.Windows.Forms.MouseEventHandler(this.IS_Path_Box_MouseUp);
            // 
            // PathContext
            // 
            this.PathContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PathContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripSeparator1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.PathContext.Name = "contextMenuStrip1";
            this.PathContext.Size = new System.Drawing.Size(219, 114);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(218, 26);
            this.toolStripMenuItem5.Text = "Check All...";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.ISCheckAll_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(218, 26);
            this.toolStripMenuItem6.Text = "Uncheck All...";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.ISUncheckAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Checked = true;
            this.toolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(218, 26);
            this.toolStripMenuItem3.Text = "Sort by Arrival Time...";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.SortPaths);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(218, 26);
            this.toolStripMenuItem4.Text = "Sort by Order...";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.SortPaths);
            // 
            // PathCount
            // 
            this.PathCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PathCount.AutoSize = true;
            this.PathCount.Enabled = false;
            this.PathCount.Location = new System.Drawing.Point(441, 199);
            this.PathCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PathCount.Name = "PathCount";
            this.PathCount.Size = new System.Drawing.Size(72, 17);
            this.PathCount.TabIndex = 8;
            this.PathCount.Text = "Pending...";
            this.PathCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FromMeshSphereToolStripMenuItem,
            this.FromPointInputToolStripMenuItem});
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(257, 26);
            this.ToolStripMenuItem1.Text = "Omni-Directional Source...";
            // 
            // FromMeshSphereToolStripMenuItem
            // 
            this.FromMeshSphereToolStripMenuItem.Name = "FromMeshSphereToolStripMenuItem";
            this.FromMeshSphereToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.FromMeshSphereToolStripMenuItem.Text = "From MeshSphere";
            // 
            // FromPointInputToolStripMenuItem
            // 
            this.FromPointInputToolStripMenuItem.Name = "FromPointInputToolStripMenuItem";
            this.FromPointInputToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.FromPointInputToolStripMenuItem.Text = "From Point Input";
            // 
            // DirectionalSourceToolStripMenuItem
            // 
            this.DirectionalSourceToolStripMenuItem.Name = "DirectionalSourceToolStripMenuItem";
            this.DirectionalSourceToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.DirectionalSourceToolStripMenuItem.Text = "Directional Source...";
            // 
            // SelectSourceToolStripMenuItem1
            // 
            this.SelectSourceToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.DirectionalSourceToolStripMenuItem});
            this.SelectSourceToolStripMenuItem1.Name = "SelectSourceToolStripMenuItem1";
            this.SelectSourceToolStripMenuItem1.Size = new System.Drawing.Size(84, 20);
            this.SelectSourceToolStripMenuItem1.Text = "Select Source";
            // 
            // SelectASphereToolStripMenuItem
            // 
            this.SelectASphereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FromSphereObjectToolStripMenuItem1,
            this.FromPointInputToolStripMenuItem2});
            this.SelectASphereToolStripMenuItem.Name = "SelectASphereToolStripMenuItem";
            this.SelectASphereToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.SelectASphereToolStripMenuItem.Text = "Select...";
            // 
            // FromSphereObjectToolStripMenuItem1
            // 
            this.FromSphereObjectToolStripMenuItem1.Name = "FromSphereObjectToolStripMenuItem1";
            this.FromSphereObjectToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.FromSphereObjectToolStripMenuItem1.Text = "From Sphere Object";
            // 
            // FromPointInputToolStripMenuItem2
            // 
            this.FromPointInputToolStripMenuItem2.Name = "FromPointInputToolStripMenuItem2";
            this.FromPointInputToolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.FromPointInputToolStripMenuItem2.Text = "From Point Input";
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectASphereToolStripMenuItem});
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(93, 20);
            this.ToolStripMenuItem2.Text = "Select Receiver";
            // 
            // SP_menu
            // 
            this.SP_menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.SP_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.SP_menu.Location = new System.Drawing.Point(0, 0);
            this.SP_menu.Name = "SP_menu";
            this.SP_menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.SP_menu.Size = new System.Drawing.Size(533, 28);
            this.SP_menu.TabIndex = 14;
            this.SP_menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDataToolStripMenuItem,
            this.saveDataToolStripMenuItem,
            this.saveParameterResultsToolStripMenuItem,
            this.savePTBFormatToolStripMenuItem,
            this.saveVRSpectraToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openDataToolStripMenuItem
            // 
            this.openDataToolStripMenuItem.Name = "openDataToolStripMenuItem";
            this.openDataToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.openDataToolStripMenuItem.Text = "Open Data...";
            this.openDataToolStripMenuItem.Click += new System.EventHandler(this.OpenDataToolStripMenuItem_Click);
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.saveDataToolStripMenuItem.Text = "Save Data";
            this.saveDataToolStripMenuItem.Click += new System.EventHandler(this.SaveDataToolStripMenuItem_Click);
            // 
            // saveParameterResultsToolStripMenuItem
            // 
            this.saveParameterResultsToolStripMenuItem.Name = "saveParameterResultsToolStripMenuItem";
            this.saveParameterResultsToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.saveParameterResultsToolStripMenuItem.Text = "Save Results";
            this.saveParameterResultsToolStripMenuItem.Click += new System.EventHandler(this.SaveResultsToolStripMenuItem_Click);
            // 
            // savePTBFormatToolStripMenuItem
            // 
            this.savePTBFormatToolStripMenuItem.Name = "savePTBFormatToolStripMenuItem";
            this.savePTBFormatToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.savePTBFormatToolStripMenuItem.Text = "Save PTB Format";
            this.savePTBFormatToolStripMenuItem.Click += new System.EventHandler(this.savePTBFormatToolStripMenuItem_Click);
            // 
            // saveVRSpectraToolStripMenuItem
            // 
            this.saveVRSpectraToolStripMenuItem.Name = "saveVRSpectraToolStripMenuItem";
            this.saveVRSpectraToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            // 
            // label64
            // 
            this.label64.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label64.AutoSize = true;
            this.label64.BackColor = System.Drawing.Color.Red;
            this.label64.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label64.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label64.Location = new System.Drawing.Point(379, 141);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(89, 17);
            this.label64.TabIndex = 86;
            this.label64.Text = "Experimental";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Pach_Hybrid_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.SP_menu);
            this.Controls.Add(this.Tabs);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pach_Hybrid_Control";
            this.Size = new System.Drawing.Size(533, 770);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Abs4kOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs8kOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs2kOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs1kOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs500Out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs250Out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs125Out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs63Out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs125)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs250)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs500)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs1k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs2k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs4k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abs8k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbsFlat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScatFlat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat8kOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat8kv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat4kv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat4kOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat2kOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat2kv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat1kv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat1kOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat500Out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat500v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat250v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat250Out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat125Out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat125v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat63v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scat63Out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmartMat_Display)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Air_Pressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rel_Humidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Air_Temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CO_TIME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RT_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Spec_RayCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Order)).EndInit();
            this.TabPage4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Absorption.ResumeLayout(false);
            this.Scattering.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_quart_lambda)).EndInit();
            this.Transparency.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_Flat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_8k_Out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_8kv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_4k_Out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_4kv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_2k_Out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_2kv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_63v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_63_Out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_1k_Out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_1kv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_125_Out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_125v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_500_Out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_250v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_500v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trans_250_Out)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TL8k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL4k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL2k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL1k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL500)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL250)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL125)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL63)).EndInit();
            this.TabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.SourceContext.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Alt_Choice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Azi_Choice)).EndInit();
            this.PathContext.ResumeLayout(false);
            this.SP_menu.ResumeLayout(false);
            this.SP_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }
            internal System.Windows.Forms.Button Calculate;
            internal System.Windows.Forms.CheckBox RTBox;
            internal System.Windows.Forms.CheckBox ISBox;
            internal System.Windows.Forms.TabControl Tabs;
            internal System.Windows.Forms.TabPage TabPage1;
            internal System.Windows.Forms.NumericUpDown Image_Order;
            internal System.Windows.Forms.NumericUpDown RT_Count;
            internal System.Windows.Forms.Label Label1;
            internal System.Windows.Forms.Label Label2;
            internal System.Windows.Forms.Label COTime;
            internal System.Windows.Forms.NumericUpDown CO_TIME;
            internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
            internal System.Windows.Forms.ToolStripMenuItem FromMeshSphereToolStripMenuItem;
            internal System.Windows.Forms.ToolStripMenuItem FromPointInputToolStripMenuItem;
            internal System.Windows.Forms.ToolStripMenuItem DirectionalSourceToolStripMenuItem;
            internal System.Windows.Forms.ToolStripMenuItem SelectSourceToolStripMenuItem1;
            internal System.Windows.Forms.ToolStripMenuItem SelectASphereToolStripMenuItem;
            internal System.Windows.Forms.ToolStripMenuItem FromSphereObjectToolStripMenuItem1;
            internal System.Windows.Forms.ToolStripMenuItem FromPointInputToolStripMenuItem2;
            internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
            internal System.Windows.Forms.TabPage TabPage3;
            internal System.Windows.Forms.TabPage TabPage4;
            internal System.Windows.Forms.Label Label5;
            internal System.Windows.Forms.Label Label7;
            internal System.Windows.Forms.Label Label8;
            internal System.Windows.Forms.Label Label6;
            internal System.Windows.Forms.Label Label9;
            internal System.Windows.Forms.Label Label10;
            internal System.Windows.Forms.Label Label11;
            internal System.Windows.Forms.Label Label12;
            internal System.Windows.Forms.Label Label13;
            internal System.Windows.Forms.TrackBar Abs63;
            internal System.Windows.Forms.TrackBar Abs125;
            internal System.Windows.Forms.TrackBar Abs8k;
            internal System.Windows.Forms.TrackBar Abs500;
            internal System.Windows.Forms.TrackBar Abs4k;
            internal System.Windows.Forms.TrackBar Abs2k;
            internal System.Windows.Forms.TrackBar Abs1k;
            internal System.Windows.Forms.TrackBar Abs250;
            internal System.Windows.Forms.TrackBar Scat63v;
            internal System.Windows.Forms.TrackBar Scat125v;
            internal System.Windows.Forms.TrackBar Scat8kv;
            internal System.Windows.Forms.TrackBar Scat500v;
            internal System.Windows.Forms.TrackBar Scat4kv;
            internal System.Windows.Forms.TrackBar Scat2kv;
            internal System.Windows.Forms.TrackBar Scat1kv;
            internal System.Windows.Forms.TrackBar Scat250v;
            internal System.Windows.Forms.Label LayerLbl;
            internal System.Windows.Forms.Label Mat_Lbl;
            internal System.Windows.Forms.ListBox Material_Lib;
            internal System.Windows.Forms.Label Label17;
            internal System.Windows.Forms.ComboBox ReceiverSelection;
            internal System.Windows.Forms.GroupBox GroupBox3;
            internal System.Windows.Forms.Label SRT4;
            internal System.Windows.Forms.Label SRT3;
            internal System.Windows.Forms.Label SRT2;
            internal System.Windows.Forms.Label SRT1;
            internal System.Windows.Forms.Label SRT8;
            internal System.Windows.Forms.Label SRT7;
            internal System.Windows.Forms.Label SRT6;
            internal System.Windows.Forms.Label SRT5;
            internal System.Windows.Forms.ComboBox LayerDisplay;
            internal System.Windows.Forms.Label PathCount;
            internal System.Windows.Forms.ComboBox Parameter_Choice;
            internal System.Windows.Forms.GroupBox GroupBox4;
            internal System.Windows.Forms.Label Label3;
            internal System.Windows.Forms.Label AirTemp;
            internal System.Windows.Forms.NumericUpDown Rel_Humidity;
            internal System.Windows.Forms.NumericUpDown Air_Temp;
            internal System.Windows.Forms.Label Label19;
            internal System.Windows.Forms.NumericUpDown Air_Pressure;
            internal System.Windows.Forms.CheckBox Specular_Trace;
            internal System.Windows.Forms.NumericUpDown Spec_RayCount;
            internal System.Windows.Forms.Label Label21;
            internal System.Windows.Forms.ComboBox Atten_Method;
            internal System.Windows.Forms.ComboBox Receiver_Choice;
            internal System.Windows.Forms.Label label20;
            internal System.Windows.Forms.TrackBar ScatFlat;
            private System.Windows.Forms.NumericUpDown Abs63Out;
            private System.Windows.Forms.NumericUpDown Abs8kOut;
            private System.Windows.Forms.NumericUpDown Abs4kOut;
            private System.Windows.Forms.NumericUpDown Abs2kOut;
            private System.Windows.Forms.NumericUpDown Abs1kOut;
            private System.Windows.Forms.NumericUpDown Abs500Out;
            private System.Windows.Forms.NumericUpDown Abs250Out;
            private System.Windows.Forms.NumericUpDown Abs125Out;
            private System.Windows.Forms.NumericUpDown Scat8kOut;
            private System.Windows.Forms.NumericUpDown Scat4kOut;
            private System.Windows.Forms.NumericUpDown Scat2kOut;
            private System.Windows.Forms.NumericUpDown Scat1kOut;
            private System.Windows.Forms.NumericUpDown Scat500Out;
            private System.Windows.Forms.NumericUpDown Scat250Out;
            private System.Windows.Forms.NumericUpDown Scat125Out;
            private System.Windows.Forms.NumericUpDown Scat63Out;
            internal System.Windows.Forms.Label label24;
            private System.Windows.Forms.GroupBox groupBox5;
            private System.Windows.Forms.Button Save_Material;
            private System.Windows.Forms.MaskedTextBox Material_Name;
            private System.Windows.Forms.CheckBox EdgeFreq;
            private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
            private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
            private System.Windows.Forms.Label label18;
            private System.Windows.Forms.Label label22;
            internal System.Windows.Forms.CheckedListBox SourceList;
            internal System.Windows.Forms.Label label15;
            private System.Windows.Forms.Label ISOCOMP;
            private System.Windows.Forms.TrackBar AbsFlat;
            internal System.Windows.Forms.CheckBox BTM_ED;
            internal System.Windows.Forms.Label label27;
            internal System.Windows.Forms.Label label26;
            private System.Windows.Forms.NumericUpDown Alt_Choice;
            private System.Windows.Forms.NumericUpDown Azi_Choice;
            internal System.Windows.Forms.CheckedListBox IS_Path_Box;
            internal System.Windows.Forms.ComboBox Graph_Octave;
            private ZedGraph.ZedGraphControl Analysis_View;
            private System.Windows.Forms.CheckBox Normalize_Graph;
            private System.Windows.Forms.CheckBox LockUserScale;
            internal System.Windows.Forms.ComboBox Graph_Type;
            internal System.Windows.Forms.ComboBox Source_Aim;
            internal System.Windows.Forms.Label label25;
            private System.Windows.Forms.Button Abs_Designer;
            private System.Windows.Forms.DataVisualization.Charting.Chart SmartMat_Display;
            private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
            internal System.Windows.Forms.Label label37;
            internal System.Windows.Forms.Label label38;
            internal System.Windows.Forms.Label label39;
            internal System.Windows.Forms.Label label40;
            internal System.Windows.Forms.Label label41;
            internal System.Windows.Forms.Label label42;
            internal System.Windows.Forms.Label label43;
            internal System.Windows.Forms.Label label44;
            internal System.Windows.Forms.Label label45;
            private System.Windows.Forms.TabControl tabControl1;
            private System.Windows.Forms.TabPage Absorption;
            private System.Windows.Forms.TabPage Scattering;
            private System.Windows.Forms.TabPage Transparency;
            private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
            internal System.Windows.Forms.Label label23;
            internal System.Windows.Forms.TrackBar Trans_Flat;
            internal System.Windows.Forms.Label label28;
            private System.Windows.Forms.NumericUpDown Trans_8k_Out;
            internal System.Windows.Forms.Label label29;
            internal System.Windows.Forms.TrackBar Trans_8kv;
            internal System.Windows.Forms.Label label30;
            internal System.Windows.Forms.Label label31;
            internal System.Windows.Forms.Label label32;
            private System.Windows.Forms.NumericUpDown Trans_4k_Out;
            internal System.Windows.Forms.TrackBar Trans_4kv;
            internal System.Windows.Forms.Label label33;
            internal System.Windows.Forms.Label label34;
            private System.Windows.Forms.NumericUpDown Trans_2k_Out;
            internal System.Windows.Forms.Label label35;
            internal System.Windows.Forms.TrackBar Trans_2kv;
            private System.Windows.Forms.Label label36;
            internal System.Windows.Forms.TrackBar Trans_63v;
            private System.Windows.Forms.NumericUpDown Trans_63_Out;
            private System.Windows.Forms.NumericUpDown Trans_1k_Out;
            internal System.Windows.Forms.TrackBar Trans_1kv;
            private System.Windows.Forms.NumericUpDown Trans_125_Out;
            internal System.Windows.Forms.TrackBar Trans_125v;
            private System.Windows.Forms.NumericUpDown Trans_500_Out;
            internal System.Windows.Forms.TrackBar Trans_250v;
            internal System.Windows.Forms.TrackBar Trans_500v;
            private System.Windows.Forms.NumericUpDown Trans_250_Out;
            private System.Windows.Forms.MenuStrip SP_menu;
            private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem openDataToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem saveParameterResultsToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem savePTBFormatToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem saveVRSpectraToolStripMenuItem;
            private System.Windows.Forms.Button Auralisation;
            private System.Windows.Forms.Button Delete_Material;
            private System.Windows.Forms.ContextMenuStrip SourceContext;
            private System.Windows.Forms.ToolStripMenuItem PowerMod;
            private System.Windows.Forms.ToolStripMenuItem DelayMod;
            private System.Windows.Forms.Label label14;
            private System.Windows.Forms.RadioButton Spec_Rays;
            private System.Windows.Forms.RadioButton DetailedConvergence;
            private System.Windows.Forms.RadioButton Minimum_Convergence;
            private System.Windows.Forms.Label label16;
            private System.Windows.Forms.Label quart_lambda;
            internal System.Windows.Forms.TrackBar user_quart_lambda;
            private System.Windows.Forms.Button PlasterScatter;
            private System.Windows.Forms.Button GlassScatter;
            private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
            private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
            internal System.Windows.Forms.Label label4;
            private System.Windows.Forms.ContextMenuStrip PathContext;
            private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
            private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
            private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
            private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
            private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
            private System.Windows.Forms.TabControl tabControl2;
            private System.Windows.Forms.TabPage tabPage2;
            private System.Windows.Forms.CheckBox Trans_Check;
            private System.Windows.Forms.TabPage tabPage5;
            private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
            internal System.Windows.Forms.Label label63;
            private System.Windows.Forms.GroupBox groupBox1;
            private System.Windows.Forms.Button DeleteAssembly;
            private System.Windows.Forms.Button SaveAssembly;
            private System.Windows.Forms.MaskedTextBox IsolationAssemblies;
            private System.Windows.Forms.Label label53;
            private System.Windows.Forms.CheckBox TL_Check;
            private System.Windows.Forms.NumericUpDown TL8k;
            internal System.Windows.Forms.Label label54;
            internal System.Windows.Forms.Label label52;
            internal System.Windows.Forms.Label label51;
            internal System.Windows.Forms.Label label48;
            internal System.Windows.Forms.Label label46;
            internal System.Windows.Forms.Label label47;
            internal System.Windows.Forms.Label label49;
            internal System.Windows.Forms.Label label50;
            private System.Windows.Forms.NumericUpDown TL4k;
            private System.Windows.Forms.NumericUpDown TL2k;
            private System.Windows.Forms.NumericUpDown TL1k;
            private System.Windows.Forms.NumericUpDown TL500;
            private System.Windows.Forms.NumericUpDown TL250;
            private System.Windows.Forms.NumericUpDown TL125;
            private System.Windows.Forms.NumericUpDown TL63;
            private System.Windows.Forms.Label label55;
            private System.Windows.Forms.Label label56;
            private System.Windows.Forms.Label label57;
            private System.Windows.Forms.Label label58;
            private System.Windows.Forms.Label label59;
            private System.Windows.Forms.Label label60;
            private System.Windows.Forms.Label label61;
            private System.Windows.Forms.Label label62;
            internal System.Windows.Forms.ListBox Isolation_Lib;
            private System.Windows.Forms.Label label64;
        }
    }
}