





#pragma warning disable 1591
#pragma warning disable 0108
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Team Development for Sitecore.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;   
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Fields;
using Sitecore.Globalization;
using Sitecore.Data;



namespace Testground.Model.Glass.Model.Glass
{

	public partial interface IGlassBase{
		
		[SitecoreId]
		Guid Id{ get; }

		[SitecoreInfo(SitecoreInfoType.Language)]
        Language Language{ get; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; }

		[SitecoreInfo(SitecoreInfoType.Url)]
        string Url { get; }

	}

	public abstract partial class GlassBase : IGlassBase{
		
		[SitecoreId]
		public virtual Guid Id{ get; private set;}

		[SitecoreInfo(SitecoreInfoType.Language)]
        public virtual Language Language{ get; private set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual int Version { get; private set; }

		[SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; private set; }
	}
}









namespace Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data
{


 	/// <summary>
	/// ITitle_Field Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Data/Title Field</para>	
	/// <para>ID: 352c79b1-b75c-4918-9b5f-fee4bffa5642</para>	
	/// </summary>
	[SitecoreType(TemplateId=ITitle_FieldConstants.TemplateIdString )] //, Cachable = true
	public partial interface ITitle_Field : IGlassBase 
	{
								/// <summary>
					/// The Content Title field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: dd1074e7-7f1c-4178-9078-219edf3bb445</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ITitle_FieldConstants.Content_TitleFieldName)]
					string Content_Title  {get; set;}
			
				}


	public static partial class ITitle_FieldConstants{

			public const string TemplateIdString = "352c79b1-b75c-4918-9b5f-fee4bffa5642";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Title Field";

					
			public static readonly ID Content_TitleFieldId = new ID("dd1074e7-7f1c-4178-9078-219edf3bb445");
			public const string Content_TitleFieldName = "Content Title";
			
			

	}

	
	/// <summary>
	/// Title_Field
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Data/Title Field</para>	
	/// <para>ID: 352c79b1-b75c-4918-9b5f-fee4bffa5642</para>	
	/// </summary>
	[SitecoreType(TemplateId=ITitle_FieldConstants.TemplateIdString)] //, Cachable = true
	public partial class Title_Field  : GlassBase, ITitle_Field 
	{
	   
						/// <summary>
				/// The Content Title field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: dd1074e7-7f1c-4178-9078-219edf3bb445</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ITitle_FieldConstants.Content_TitleFieldName)]
				public virtual string Content_Title  {get; set;}
					
			
	}
}










namespace Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data
{


 	/// <summary>
	/// IBody_Field Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Data/Body Field</para>	
	/// <para>ID: 4210390c-ad6b-451e-abdb-7f4f04377778</para>	
	/// </summary>
	[SitecoreType(TemplateId=IBody_FieldConstants.TemplateIdString )] //, Cachable = true
	public partial interface IBody_Field : IGlassBase 
	{
								/// <summary>
					/// The Content Body field.
					/// <para></para>
					/// <para>Field Type: Rich Text</para>		
					/// <para>Field ID: 0240b88c-4348-472e-a9ad-22aac7d3dae2</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(IBody_FieldConstants.Content_BodyFieldName)]
					string Content_Body  {get; set;}
			
				}


	public static partial class IBody_FieldConstants{

			public const string TemplateIdString = "4210390c-ad6b-451e-abdb-7f4f04377778";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Body Field";

					
			public static readonly ID Content_BodyFieldId = new ID("0240b88c-4348-472e-a9ad-22aac7d3dae2");
			public const string Content_BodyFieldName = "Content Body";
			
			

	}

	
	/// <summary>
	/// Body_Field
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Data/Body Field</para>	
	/// <para>ID: 4210390c-ad6b-451e-abdb-7f4f04377778</para>	
	/// </summary>
	[SitecoreType(TemplateId=IBody_FieldConstants.TemplateIdString)] //, Cachable = true
	public partial class Body_Field  : GlassBase, IBody_Field 
	{
	   
						/// <summary>
				/// The Content Body field.
				/// <para></para>
				/// <para>Field Type: Rich Text</para>		
				/// <para>Field ID: 0240b88c-4348-472e-a9ad-22aac7d3dae2</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IBody_FieldConstants.Content_BodyFieldName)]
				public virtual string Content_Body  {get; set;}
					
			
	}
}










namespace Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data
{


 	/// <summary>
	/// IImage_Field Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Data/Image Field</para>	
	/// <para>ID: 54a1b008-7584-4260-8571-2645f3c5786d</para>	
	/// </summary>
	[SitecoreType(TemplateId=IImage_FieldConstants.TemplateIdString )] //, Cachable = true
	public partial interface IImage_Field : IGlassBase 
	{
								/// <summary>
					/// The Content Image field.
					/// <para></para>
					/// <para>Field Type: Image</para>		
					/// <para>Field ID: a7d05526-c33d-41fb-a2bb-5bd43cc4ecff</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(IImage_FieldConstants.Content_ImageFieldName)]
					Image Content_Image  {get; set;}
			
				}


	public static partial class IImage_FieldConstants{

			public const string TemplateIdString = "54a1b008-7584-4260-8571-2645f3c5786d";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Image Field";

					
			public static readonly ID Content_ImageFieldId = new ID("a7d05526-c33d-41fb-a2bb-5bd43cc4ecff");
			public const string Content_ImageFieldName = "Content Image";
			
			

	}

	
	/// <summary>
	/// Image_Field
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Data/Image Field</para>	
	/// <para>ID: 54a1b008-7584-4260-8571-2645f3c5786d</para>	
	/// </summary>
	[SitecoreType(TemplateId=IImage_FieldConstants.TemplateIdString)] //, Cachable = true
	public partial class Image_Field  : GlassBase, IImage_Field 
	{
	   
						/// <summary>
				/// The Content Image field.
				/// <para></para>
				/// <para>Field Type: Image</para>		
				/// <para>Field ID: a7d05526-c33d-41fb-a2bb-5bd43cc4ecff</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IImage_FieldConstants.Content_ImageFieldName)]
				public virtual Image Content_Image  {get; set;}
					
			
	}
}










namespace Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Page_Types
{


 	/// <summary>
	/// IContent_Page Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Page Types/Content Page</para>	
	/// <para>ID: 8dac2938-20ec-4cb0-ba4e-0de432aa369e</para>	
	/// </summary>
	[SitecoreType(TemplateId=IContent_PageConstants.TemplateIdString )] //, Cachable = true
	public partial interface IContent_Page : IGlassBase , global::Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data.INavigation, global::Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data.ITitle_Field, global::Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data.IBody_Field, global::Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data.IImage_Field, global::Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data.ISeo
	{
				}


	public static partial class IContent_PageConstants{

			public const string TemplateIdString = "8dac2938-20ec-4cb0-ba4e-0de432aa369e";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Content Page";

					
			public static readonly ID Hide_From_NavigationFieldId = new ID("9ab37834-1079-4a6e-b5b5-774c55ae8589");
			public const string Hide_From_NavigationFieldName = "Hide From Navigation";
			
					
			public static readonly ID Navigation_TitleFieldId = new ID("a2659cbf-9c0c-4703-9cd9-86b5c10b972e");
			public const string Navigation_TitleFieldName = "Navigation Title";
			
					
			public static readonly ID Content_TitleFieldId = new ID("dd1074e7-7f1c-4178-9078-219edf3bb445");
			public const string Content_TitleFieldName = "Content Title";
			
					
			public static readonly ID Content_BodyFieldId = new ID("0240b88c-4348-472e-a9ad-22aac7d3dae2");
			public const string Content_BodyFieldName = "Content Body";
			
					
			public static readonly ID Content_ImageFieldId = new ID("a7d05526-c33d-41fb-a2bb-5bd43cc4ecff");
			public const string Content_ImageFieldName = "Content Image";
			
					
			public static readonly ID Meta_DescriptionFieldId = new ID("74585fed-e4a9-46bd-b6a0-541b3e865f8e");
			public const string Meta_DescriptionFieldName = "Meta Description";
			
					
			public static readonly ID Meta_KeywordsFieldId = new ID("6cbc9cfe-37bf-4bfa-8a44-a1a3b5993742");
			public const string Meta_KeywordsFieldName = "Meta Keywords";
			
					
			public static readonly ID Meta_TitleFieldId = new ID("e942d8da-d769-42f0-a5ce-859d5b76abf0");
			public const string Meta_TitleFieldName = "Meta Title";
			
			

	}

	
	/// <summary>
	/// Content_Page
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Page Types/Content Page</para>	
	/// <para>ID: 8dac2938-20ec-4cb0-ba4e-0de432aa369e</para>	
	/// </summary>
	[SitecoreType(TemplateId=IContent_PageConstants.TemplateIdString)] //, Cachable = true
	public partial class Content_Page  : GlassBase, IContent_Page 
	{
	   
						/// <summary>
				/// The Hide From Navigation field.
				/// <para></para>
				/// <para>Field Type: Checkbox</para>		
				/// <para>Field ID: 9ab37834-1079-4a6e-b5b5-774c55ae8589</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IContent_PageConstants.Hide_From_NavigationFieldName)]
				public virtual bool Hide_From_Navigation  {get; set;}
					
						/// <summary>
				/// The Navigation Title field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: a2659cbf-9c0c-4703-9cd9-86b5c10b972e</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IContent_PageConstants.Navigation_TitleFieldName)]
				public virtual string Navigation_Title  {get; set;}
					
						/// <summary>
				/// The Content Title field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: dd1074e7-7f1c-4178-9078-219edf3bb445</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IContent_PageConstants.Content_TitleFieldName)]
				public virtual string Content_Title  {get; set;}
					
						/// <summary>
				/// The Content Body field.
				/// <para></para>
				/// <para>Field Type: Rich Text</para>		
				/// <para>Field ID: 0240b88c-4348-472e-a9ad-22aac7d3dae2</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IContent_PageConstants.Content_BodyFieldName)]
				public virtual string Content_Body  {get; set;}
					
						/// <summary>
				/// The Content Image field.
				/// <para></para>
				/// <para>Field Type: Image</para>		
				/// <para>Field ID: a7d05526-c33d-41fb-a2bb-5bd43cc4ecff</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IContent_PageConstants.Content_ImageFieldName)]
				public virtual Image Content_Image  {get; set;}
					
						/// <summary>
				/// The Meta Description field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 74585fed-e4a9-46bd-b6a0-541b3e865f8e</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IContent_PageConstants.Meta_DescriptionFieldName)]
				public virtual string Meta_Description  {get; set;}
					
						/// <summary>
				/// The Meta Keywords field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 6cbc9cfe-37bf-4bfa-8a44-a1a3b5993742</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IContent_PageConstants.Meta_KeywordsFieldName)]
				public virtual string Meta_Keywords  {get; set;}
					
						/// <summary>
				/// The Meta Title field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: e942d8da-d769-42f0-a5ce-859d5b76abf0</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IContent_PageConstants.Meta_TitleFieldName)]
				public virtual string Meta_Title  {get; set;}
					
			
	}
}










namespace Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data
{


 	/// <summary>
	/// ISeo Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Data/Seo</para>	
	/// <para>ID: a7cb2cd5-c4b1-46a6-b92f-4ef8185b45ec</para>	
	/// </summary>
	[SitecoreType(TemplateId=ISeoConstants.TemplateIdString )] //, Cachable = true
	public partial interface ISeo : IGlassBase 
	{
								/// <summary>
					/// The Meta Description field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: 74585fed-e4a9-46bd-b6a0-541b3e865f8e</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ISeoConstants.Meta_DescriptionFieldName)]
					string Meta_Description  {get; set;}
			
								/// <summary>
					/// The Meta Keywords field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: 6cbc9cfe-37bf-4bfa-8a44-a1a3b5993742</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ISeoConstants.Meta_KeywordsFieldName)]
					string Meta_Keywords  {get; set;}
			
								/// <summary>
					/// The Meta Title field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: e942d8da-d769-42f0-a5ce-859d5b76abf0</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(ISeoConstants.Meta_TitleFieldName)]
					string Meta_Title  {get; set;}
			
				}


	public static partial class ISeoConstants{

			public const string TemplateIdString = "a7cb2cd5-c4b1-46a6-b92f-4ef8185b45ec";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Seo";

					
			public static readonly ID Meta_DescriptionFieldId = new ID("74585fed-e4a9-46bd-b6a0-541b3e865f8e");
			public const string Meta_DescriptionFieldName = "Meta Description";
			
					
			public static readonly ID Meta_KeywordsFieldId = new ID("6cbc9cfe-37bf-4bfa-8a44-a1a3b5993742");
			public const string Meta_KeywordsFieldName = "Meta Keywords";
			
					
			public static readonly ID Meta_TitleFieldId = new ID("e942d8da-d769-42f0-a5ce-859d5b76abf0");
			public const string Meta_TitleFieldName = "Meta Title";
			
			

	}

	
	/// <summary>
	/// Seo
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Data/Seo</para>	
	/// <para>ID: a7cb2cd5-c4b1-46a6-b92f-4ef8185b45ec</para>	
	/// </summary>
	[SitecoreType(TemplateId=ISeoConstants.TemplateIdString)] //, Cachable = true
	public partial class Seo  : GlassBase, ISeo 
	{
	   
						/// <summary>
				/// The Meta Description field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 74585fed-e4a9-46bd-b6a0-541b3e865f8e</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ISeoConstants.Meta_DescriptionFieldName)]
				public virtual string Meta_Description  {get; set;}
					
						/// <summary>
				/// The Meta Keywords field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: 6cbc9cfe-37bf-4bfa-8a44-a1a3b5993742</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ISeoConstants.Meta_KeywordsFieldName)]
				public virtual string Meta_Keywords  {get; set;}
					
						/// <summary>
				/// The Meta Title field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: e942d8da-d769-42f0-a5ce-859d5b76abf0</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(ISeoConstants.Meta_TitleFieldName)]
				public virtual string Meta_Title  {get; set;}
					
			
	}
}










namespace Testground.Model.Glass.Model.Glass.sitecore.templates.User_Defined.Data
{


 	/// <summary>
	/// INavigation Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Data/Navigation</para>	
	/// <para>ID: f80baa4d-5f8b-40ea-be43-20d649b2c92d</para>	
	/// </summary>
	[SitecoreType(TemplateId=INavigationConstants.TemplateIdString )] //, Cachable = true
	public partial interface INavigation : IGlassBase 
	{
								/// <summary>
					/// The Hide From Navigation field.
					/// <para></para>
					/// <para>Field Type: Checkbox</para>		
					/// <para>Field ID: 9ab37834-1079-4a6e-b5b5-774c55ae8589</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(INavigationConstants.Hide_From_NavigationFieldName)]
					bool Hide_From_Navigation  {get; set;}
			
								/// <summary>
					/// The Navigation Title field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: a2659cbf-9c0c-4703-9cd9-86b5c10b972e</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(INavigationConstants.Navigation_TitleFieldName)]
					string Navigation_Title  {get; set;}
			
				}


	public static partial class INavigationConstants{

			public const string TemplateIdString = "f80baa4d-5f8b-40ea-be43-20d649b2c92d";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Navigation";

					
			public static readonly ID Hide_From_NavigationFieldId = new ID("9ab37834-1079-4a6e-b5b5-774c55ae8589");
			public const string Hide_From_NavigationFieldName = "Hide From Navigation";
			
					
			public static readonly ID Navigation_TitleFieldId = new ID("a2659cbf-9c0c-4703-9cd9-86b5c10b972e");
			public const string Navigation_TitleFieldName = "Navigation Title";
			
			

	}

	
	/// <summary>
	/// Navigation
	/// <para></para>
	/// <para>Path: /sitecore/templates/User Defined/Data/Navigation</para>	
	/// <para>ID: f80baa4d-5f8b-40ea-be43-20d649b2c92d</para>	
	/// </summary>
	[SitecoreType(TemplateId=INavigationConstants.TemplateIdString)] //, Cachable = true
	public partial class Navigation  : GlassBase, INavigation 
	{
	   
						/// <summary>
				/// The Hide From Navigation field.
				/// <para></para>
				/// <para>Field Type: Checkbox</para>		
				/// <para>Field ID: 9ab37834-1079-4a6e-b5b5-774c55ae8589</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(INavigationConstants.Hide_From_NavigationFieldName)]
				public virtual bool Hide_From_Navigation  {get; set;}
					
						/// <summary>
				/// The Navigation Title field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: a2659cbf-9c0c-4703-9cd9-86b5c10b972e</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(INavigationConstants.Navigation_TitleFieldName)]
				public virtual string Navigation_Title  {get; set;}
					
			
	}
}
