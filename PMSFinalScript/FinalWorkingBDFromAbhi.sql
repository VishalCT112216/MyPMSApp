USE [PMS]
GO
/****** Object:  Table [dbo].[Allergy]    Script Date: 12/30/2021 12:11:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Allergy](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AllergyId] [varchar](50) NOT NULL,
	[AllergyType] [varchar](100) NULL,
	[AllergyName] [varchar](100) NULL,
	[ClinicalInfo] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[AllergyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diagnosis]    Script Date: 12/30/2021 12:11:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnosis](
	[Id] [int] NULL,
	[DiagnosisId] [int] IDENTITY(1,1) NOT NULL,
	[DiagnosisCode] [varchar](25) NULL,
	[DiagnosisDescription] [varchar](50) NULL,
	[DiagnosisIsDepricated] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[DiagnosisId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drug]    Script Date: 12/30/2021 12:11:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drug](
	[Id] [int] NULL,
	[Drug_ID] [varchar](20) NULL,
	[Drug_Name] [varchar](50) NULL,
	[Drug_Generic_Name] [varchar](50) NULL,
	[Drug_Brand_Name] [varchar](50) NULL,
	[Drug_Form] [varchar](50) NULL,
	[Drug_Strength] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 12/30/2021 12:11:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[User_Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Old_Password] [varchar](50) NULL,
	[Title] [varchar](10) NULL,
	[Firstname] [varchar](50) NULL,
	[Lastname] [varchar](50) NULL,
	[Email_Id] [varchar](50) NULL,
	[DOB] [datetime] NULL,
	[DOJ] [datetime] NULL,
	[Contact_No] [varchar](50) NULL,
	[Status] [varchar](20) NULL,
	[Role_Id] [int] NULL,
	[IsActive] [bit] NULL,
	[Created_Date] [datetime] NULL,
	[Created_By] [varchar](20) NULL,
	[Id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[User_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientAllergyInfo]    Script Date: 12/30/2021 12:11:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientAllergyInfo](
	[Id] [int] NULL,
	[PatientAllergyInfoId] [int] IDENTITY(1,1) NOT NULL,
	[User_Id] [int] NULL,
	[HasAllergy] [bit] NULL,
	[AllergyId] [varchar](50) NULL,
	[AllergyType] [varchar](100) NULL,
	[AllergyName] [varchar](100) NULL,
	[ClinicalInfo] [varchar](500) NULL,
	[AllergyDescription] [varchar](1000) NULL,
	[IsFatal] [varchar](3) NULL,
PRIMARY KEY CLUSTERED 
(
	[PatientAllergyInfoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientDemoInfo]    Script Date: 12/30/2021 12:11:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientDemoInfo](
	[Id] [int] NULL,
	[PatientDemoInfoId] [int] IDENTITY(1,1) NOT NULL,
	[User_Id] [int] NULL,
	[title] [varchar](50) NULL,
	[fname] [varchar](50) NULL,
	[lname] [varchar](50) NULL,
	[dob] [datetime] NULL,
	[age] [varchar](20) NULL,
	[race] [varchar](50) NULL,
	[ethinicity] [varchar](50) NULL,
	[languagesKnown] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[homeAddress] [varchar](100) NULL,
	[contactNumber] [varchar](50) NULL,
	[emergencyFname] [varchar](50) NULL,
	[emergencyLname] [varchar](50) NULL,
	[relationship] [varchar](50) NULL,
	[emergencyEmail] [varchar](50) NULL,
	[EmergencyMobileNo] [varchar](50) NULL,
	[emergencyAddress] [varchar](50) NULL,
	[portalaccess] [varchar](50) NULL,
	[TypeofAllergies] [varchar](50) NULL,
	[createdDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[PatientDemoInfoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientDiagnosisInfo]    Script Date: 12/30/2021 12:11:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientDiagnosisInfo](
	[Id] [int] NULL,
	[PatientDiagnosisInfoId] [int] IDENTITY(1,1) NOT NULL,
	[DiagnosisCode] [varchar](25) NULL,
	[DiagnosisDescription] [varchar](50) NULL,
	[DiagnosisIsDepricated] [varchar](5) NULL,
	[Patient_Id] [int] NULL,
	[Physician_Id] [int] NULL,
	[Created_By] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PatientDiagnosisInfoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientMedicationInfo]    Script Date: 12/30/2021 12:11:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientMedicationInfo](
	[Id] [int] NULL,
	[PatientMedicationInfoId] [int] IDENTITY(1,1) NOT NULL,
	[Drug_ID] [varchar](20) NULL,
	[Drug_Name] [varchar](50) NULL,
	[Drug_Generic_Name] [varchar](50) NULL,
	[Drug_Brand_Name] [varchar](50) NULL,
	[Drug_Form] [varchar](50) NULL,
	[Drug_Strength] [varchar](50) NULL,
	[Patient_Id] [int] NULL,
	[Physician_Id] [int] NULL,
	[Created_By] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PatientMedicationInfoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientProcedureInfo]    Script Date: 12/30/2021 12:11:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientProcedureInfo](
	[Id] [int] NULL,
	[PatientProcedureInfoId] [int] IDENTITY(1,1) NOT NULL,
	[ProcedureCode] [varchar](25) NULL,
	[Patient_Id] [int] NULL,
	[Physician_Id] [int] NULL,
	[Created_By] [int] NULL,
	[ProcedureIsDepricated] [varchar](5) NULL,
	[ProcedureDescription] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[PatientProcedureInfoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientVitalSignInfo]    Script Date: 12/30/2021 12:11:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientVitalSignInfo](
	[Id] [int] NULL,
	[PatientVitalSignInfoId] [int] IDENTITY(1,1) NOT NULL,
	[Height] [decimal](18, 0) NULL,
	[Weight] [decimal](18, 0) NULL,
	[BloodPressure] [decimal](18, 0) NULL,
	[BodyTemperature] [decimal](18, 0) NULL,
	[RespirationRate] [decimal](18, 0) NULL,
	[Patient_Id] [int] NULL,
	[Physician_Id] [int] NULL,
	[Created_By] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PatientVitalSignInfoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProcedureData]    Script Date: 12/30/2021 12:11:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProcedureData](
	[Id] [int] NULL,
	[ProcedureId] [int] IDENTITY(1,1) NOT NULL,
	[ProcedureCode] [varchar](25) NULL,
	[ProcedureIsDepricated] [varchar](5) NULL,
	[ProcedureDescription] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProcedureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 12/30/2021 12:11:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] NULL,
	[Role_Id] [int] IDENTITY(1,1) NOT NULL,
	[Role_Name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Role_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Scheduling]    Script Date: 12/30/2021 12:11:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Scheduling](
	[Scheduling_Id] [int] IDENTITY(1,1) NOT NULL,
	[MeetingTitle] [varchar](100) NULL,
	[DescriptiveInformation] [varchar](100) NULL,
	[DateOfAppointment] [datetime] NULL,
	[TimeOfAppointment] [varchar](50) NULL,
	[Patient_Id] [int] NULL,
	[Physician_Id] [int] NULL,
	[Created_By] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Scheduling_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Allergy] ON 

INSERT [dbo].[Allergy] ([Id], [AllergyId], [AllergyType], [AllergyName], [ClinicalInfo]) VALUES (1, N'Bos d 2.0101', N'Animal', N'Bovine', N'Bos taurus')
INSERT [dbo].[Allergy] ([Id], [AllergyId], [AllergyType], [AllergyName], [ClinicalInfo]) VALUES (2, N'Bos d 3.0101', N'Animal', N'Dog', N'Bos taurus')
SET IDENTITY_INSERT [dbo].[Allergy] OFF
GO
SET IDENTITY_INSERT [dbo].[Diagnosis] ON 

INSERT [dbo].[Diagnosis] ([Id], [DiagnosisId], [DiagnosisCode], [DiagnosisDescription], [DiagnosisIsDepricated]) VALUES (1, 1, N'A00', N'Cholera ', N'Yes')
INSERT [dbo].[Diagnosis] ([Id], [DiagnosisId], [DiagnosisCode], [DiagnosisDescription], [DiagnosisIsDepricated]) VALUES (2, 2, N'B00', N'Typhoid ', N'No')
SET IDENTITY_INSERT [dbo].[Diagnosis] OFF
GO
INSERT [dbo].[Drug] ([Id], [Drug_ID], [Drug_Name], [Drug_Generic_Name], [Drug_Brand_Name], [Drug_Form], [Drug_Strength]) VALUES (1, N'CT001', N'Paracetamol', N'calpol tab', N'calpol tab', N'tablet', N'350 mg')
INSERT [dbo].[Drug] ([Id], [Drug_ID], [Drug_Name], [Drug_Generic_Name], [Drug_Brand_Name], [Drug_Form], [Drug_Strength]) VALUES (2, N'CT002', N'cetrizine', N'okacet', N'okacet', N'tablet', N'10 mg')
GO
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([User_Id], [Username], [Password], [Old_Password], [Title], [Firstname], [Lastname], [Email_Id], [DOB], [DOJ], [Contact_No], [Status], [Role_Id], [IsActive], [Created_Date], [Created_By], [Id]) VALUES (1, N'rajesh.sharma@gmail.com', N'1@Rajesh', N'1@Rajesh', N'Mr', N'Rajesh', N'sharma', N'rajesh.sharma@gmail.com', CAST(N'1997-03-11T00:00:00.000' AS DateTime), CAST(N'2016-11-10T00:00:00.000' AS DateTime), N'9594000121', N'Active', 1, 1, CAST(N'2021-12-07T18:16:24.583' AS DateTime), N'Rajesh Sharma', NULL)
INSERT [dbo].[Login] ([User_Id], [Username], [Password], [Old_Password], [Title], [Firstname], [Lastname], [Email_Id], [DOB], [DOJ], [Contact_No], [Status], [Role_Id], [IsActive], [Created_Date], [Created_By], [Id]) VALUES (2, N'rajeshAtish.sharma@gmail.com', N'1@RajeshAtish', N'1@RajeshAtish', N'Mr', N'Rajesh', N'sharma', N'rajesh.sharma@gmail.com', CAST(N'1997-03-11T00:00:00.000' AS DateTime), CAST(N'2016-11-10T00:00:00.000' AS DateTime), N'9594000121', N'Active', 1, 1, CAST(N'2021-12-07T18:16:24.583' AS DateTime), N'Rajesh Sharma', NULL)
INSERT [dbo].[Login] ([User_Id], [Username], [Password], [Old_Password], [Title], [Firstname], [Lastname], [Email_Id], [DOB], [DOJ], [Contact_No], [Status], [Role_Id], [IsActive], [Created_Date], [Created_By], [Id]) VALUES (3, N'Atish.sharma@gmail.com', N'1@Atish', N'1@OldPassAtish', N'Mr', N'Atish', N'sharma', N'rajesh.sharma@gmail.com', CAST(N'1997-03-11T00:00:00.000' AS DateTime), CAST(N'2016-11-10T00:00:00.000' AS DateTime), N'9594000121', N'Active', 1, 1, CAST(N'2021-12-07T18:16:24.583' AS DateTime), N'Rajesh Sharma', NULL)
INSERT [dbo].[Login] ([User_Id], [Username], [Password], [Old_Password], [Title], [Firstname], [Lastname], [Email_Id], [DOB], [DOJ], [Contact_No], [Status], [Role_Id], [IsActive], [Created_Date], [Created_By], [Id]) VALUES (4, N'Suraj.sharma@gmail.com', N'1@Suraj', N'1@OldPassSuraj', N'Mr', N'Suraj', N'sharma', N'Suraj.sharma@gmail.com', CAST(N'1997-03-11T00:00:00.000' AS DateTime), CAST(N'2016-11-10T00:00:00.000' AS DateTime), N'9594000121', N'Active', 2, 1, CAST(N'2021-12-07T18:16:24.583' AS DateTime), N'Rajesh Sharma', NULL)
INSERT [dbo].[Login] ([User_Id], [Username], [Password], [Old_Password], [Title], [Firstname], [Lastname], [Email_Id], [DOB], [DOJ], [Contact_No], [Status], [Role_Id], [IsActive], [Created_Date], [Created_By], [Id]) VALUES (5, N'Manisha.sharma@gmail.com', N'1@Manisha', N'1@OldPassManisha', N'Mr', N'Manisha', N'sharma', N'Manisha.sharma@gmail.com', CAST(N'1997-03-11T00:00:00.000' AS DateTime), CAST(N'2016-11-10T00:00:00.000' AS DateTime), N'9594000121', N'Active', 3, 1, CAST(N'2021-12-07T18:16:24.583' AS DateTime), N'Rajesh Sharma', NULL)
INSERT [dbo].[Login] ([User_Id], [Username], [Password], [Old_Password], [Title], [Firstname], [Lastname], [Email_Id], [DOB], [DOJ], [Contact_No], [Status], [Role_Id], [IsActive], [Created_Date], [Created_By], [Id]) VALUES (16, N'rakesh.mane@gmail.com', N'1@Demouser', N'1@Demouser', N'Mr', N'rakesh', N'mane', N'rakesh.mane@gmail.com', CAST(N'2021-11-17T00:00:00.000' AS DateTime), CAST(N'2021-11-04T00:00:00.000' AS DateTime), NULL, N'Active', 2, 1, CAST(N'2021-12-24T16:21:24.633' AS DateTime), NULL, NULL)
INSERT [dbo].[Login] ([User_Id], [Username], [Password], [Old_Password], [Title], [Firstname], [Lastname], [Email_Id], [DOB], [DOJ], [Contact_No], [Status], [Role_Id], [IsActive], [Created_Date], [Created_By], [Id]) VALUES (17, N'rakesh.mane@gmail.com', N'1@Demouser', N'1@Demouser', N'Mr.', N'rakesh', N'mane', N'rakesh.mane@gmail.com', CAST(N'2021-12-02T00:00:00.000' AS DateTime), CAST(N'2002-11-12T00:00:00.000' AS DateTime), NULL, N'Acive', 1, 1, CAST(N'2021-12-24T16:33:17.863' AS DateTime), NULL, NULL)
INSERT [dbo].[Login] ([User_Id], [Username], [Password], [Old_Password], [Title], [Firstname], [Lastname], [Email_Id], [DOB], [DOJ], [Contact_No], [Status], [Role_Id], [IsActive], [Created_Date], [Created_By], [Id]) VALUES (18, N'suraj.d@gmail.com', N'1@Demouser', N'1@Demouser', N'Mr.', N'suraj', N'd', N'suraj.d@gmail.com', CAST(N'2021-12-03T00:00:00.000' AS DateTime), CAST(N'2002-11-12T00:00:00.000' AS DateTime), NULL, N'Active', 3, 1, CAST(N'2021-12-24T16:42:36.713' AS DateTime), NULL, NULL)
INSERT [dbo].[Login] ([User_Id], [Username], [Password], [Old_Password], [Title], [Firstname], [Lastname], [Email_Id], [DOB], [DOJ], [Contact_No], [Status], [Role_Id], [IsActive], [Created_Date], [Created_By], [Id]) VALUES (20, N'abhi.ghadi@gmail.com', N'1@Demouser', N'1@Demouser', N'Mr.', N'abhi', N'ghadi', N'abhi.ghadi@gmail.com', CAST(N'2021-12-01T00:00:00.000' AS DateTime), CAST(N'2002-11-12T00:00:00.000' AS DateTime), N'6858675644', N'Active', 4, 1, CAST(N'2021-12-24T19:20:51.387' AS DateTime), NULL, NULL)
INSERT [dbo].[Login] ([User_Id], [Username], [Password], [Old_Password], [Title], [Firstname], [Lastname], [Email_Id], [DOB], [DOJ], [Contact_No], [Status], [Role_Id], [IsActive], [Created_Date], [Created_By], [Id]) VALUES (24, N'd.rane@gmail.com', N'1@Demouser', N'1@Demouser', N'Mr', N'dipesh', N'rane', N'd.rane@gmail.com', CAST(N'2021-11-02T00:00:00.000' AS DateTime), CAST(N'2021-11-11T00:00:00.000' AS DateTime), NULL, N'Active', 1, 1, CAST(N'2021-12-25T13:08:12.173' AS DateTime), NULL, NULL)
INSERT [dbo].[Login] ([User_Id], [Username], [Password], [Old_Password], [Title], [Firstname], [Lastname], [Email_Id], [DOB], [DOJ], [Contact_No], [Status], [Role_Id], [IsActive], [Created_Date], [Created_By], [Id]) VALUES (25, N'd.rane@gmail.com', N'1@Demouser', N'1@Demouser', N'Mr', N'dipesh', N'rane', N'd.rane@gmail.com', CAST(N'2021-11-09T00:00:00.000' AS DateTime), CAST(N'2021-11-10T00:00:00.000' AS DateTime), NULL, N'Active', 1, 1, CAST(N'2021-12-25T13:08:10.133' AS DateTime), NULL, NULL)
INSERT [dbo].[Login] ([User_Id], [Username], [Password], [Old_Password], [Title], [Firstname], [Lastname], [Email_Id], [DOB], [DOJ], [Contact_No], [Status], [Role_Id], [IsActive], [Created_Date], [Created_By], [Id]) VALUES (26, N'amol.s@gmail.com', N' 1@Userdemo', N' 1@Userdemo', N'Mr.', N'amol', N'sawant', N'amol.s@gmail.com', CAST(N'2021-12-01T00:00:00.000' AS DateTime), CAST(N'2002-11-12T00:00:00.000' AS DateTime), N'4466757256', N'Active', 3, 1, CAST(N'2021-12-25T13:46:25.667' AS DateTime), NULL, NULL)
INSERT [dbo].[Login] ([User_Id], [Username], [Password], [Old_Password], [Title], [Firstname], [Lastname], [Email_Id], [DOB], [DOJ], [Contact_No], [Status], [Role_Id], [IsActive], [Created_Date], [Created_By], [Id]) VALUES (27, N'kulwant.v@gmail.com', N'1@Kulwant', N'1@Kulwant', N'Mr.', N'kulwant ', N'vishawkarma', N'kulwant.v@gmail.com', CAST(N'2021-12-01T00:00:00.000' AS DateTime), CAST(N'2002-11-12T00:00:00.000' AS DateTime), N'9594000121', N'Active', 4, 1, CAST(N'2021-12-29T17:52:46.540' AS DateTime), NULL, NULL)
INSERT [dbo].[Login] ([User_Id], [Username], [Password], [Old_Password], [Title], [Firstname], [Lastname], [Email_Id], [DOB], [DOJ], [Contact_No], [Status], [Role_Id], [IsActive], [Created_Date], [Created_By], [Id]) VALUES (28, N'aditya.shinde@gmail.com', N'1@Demouser', N'1@Demouser', N'Mr', N'Aditya', N'Shinde', N'aditya.shinde@gmail.com', CAST(N'2018-02-14T00:00:00.000' AS DateTime), CAST(N'2021-11-16T00:00:00.000' AS DateTime), NULL, N'Active', 1, 1, CAST(N'2021-12-29T17:59:39.560' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Login] OFF
GO
SET IDENTITY_INSERT [dbo].[PatientAllergyInfo] ON 

INSERT [dbo].[PatientAllergyInfo] ([Id], [PatientAllergyInfoId], [User_Id], [HasAllergy], [AllergyId], [AllergyType], [AllergyName], [ClinicalInfo], [AllergyDescription], [IsFatal]) VALUES (1, 1, 1, 0, N'', N'', N'', N'', N'', N'')
INSERT [dbo].[PatientAllergyInfo] ([Id], [PatientAllergyInfoId], [User_Id], [HasAllergy], [AllergyId], [AllergyType], [AllergyName], [ClinicalInfo], [AllergyDescription], [IsFatal]) VALUES (2, 2, 2, 1, N'Bos d 2.0101', N'Animal', N'Bovine', N'Bos taurus', N'gjsgajgjah', N'No')
INSERT [dbo].[PatientAllergyInfo] ([Id], [PatientAllergyInfoId], [User_Id], [HasAllergy], [AllergyId], [AllergyType], [AllergyName], [ClinicalInfo], [AllergyDescription], [IsFatal]) VALUES (3, 4, 1, 1, N'Cav p 1.0101', N'Animal', N'Domstic', N'Cavia porcellus', N'facing since', N'Yes')
INSERT [dbo].[PatientAllergyInfo] ([Id], [PatientAllergyInfoId], [User_Id], [HasAllergy], [AllergyId], [AllergyType], [AllergyName], [ClinicalInfo], [AllergyDescription], [IsFatal]) VALUES (NULL, 6, 2, 1, N'Bos d 2.0101', N'Animal', N'Bovine', N'Bos taurus', N'Clinical Information means clinical, operative or other medical records and reports kept in the ordinary course of a Physician''s, Physician Group''s or Physician Organization''s business, and, where applicable, requested statements of Medical Necessity.', N'Yes')
INSERT [dbo].[PatientAllergyInfo] ([Id], [PatientAllergyInfoId], [User_Id], [HasAllergy], [AllergyId], [AllergyType], [AllergyName], [ClinicalInfo], [AllergyDescription], [IsFatal]) VALUES (NULL, 7, 27, 1, N'Bos d 2.0101', N'Animal', N'Bovine', N'Bos taurus', N'To diagnose and treat individual patients effectively, individual care providers and care teams must have access to at least three major types of clinical information—the patient''s health record, the rapidly changing medical-evidence base, and provider orders guiding the process of patient care.', N'No')
INSERT [dbo].[PatientAllergyInfo] ([Id], [PatientAllergyInfoId], [User_Id], [HasAllergy], [AllergyId], [AllergyType], [AllergyName], [ClinicalInfo], [AllergyDescription], [IsFatal]) VALUES (NULL, 8, 27, 1, N'Bos d 2.0101', N'Animal', N'Bovine', N'Bos taurus', N'To diagnose and treat individual patients effectively, individual care providers and care teams must have access to at least three major types of clinical information—the patient''s health record, the rapidly changing medical-evidence base, and provider orders guiding the process of patient care.', N'Yes')
SET IDENTITY_INSERT [dbo].[PatientAllergyInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[PatientDemoInfo] ON 

INSERT [dbo].[PatientDemoInfo] ([Id], [PatientDemoInfoId], [User_Id], [title], [fname], [lname], [dob], [age], [race], [ethinicity], [languagesKnown], [email], [gender], [homeAddress], [contactNumber], [emergencyFname], [emergencyLname], [relationship], [emergencyEmail], [EmergencyMobileNo], [emergencyAddress], [portalaccess], [TypeofAllergies], [createdDate]) VALUES (NULL, 1, 1, N'Mr', N'Abhimanyu', N'Ghadi', CAST(N'1997-07-16T00:00:00.000' AS DateTime), N'25', N'Indian', N'Hindu', N'Marathi', N'suraj@gmail.com', N'Mr', N'Sangli', N'73278247328727', N'someone', N'soneone', N'Sister', N'someone@gmail.com', N'4732643264872462', N'kjsahdskhduhdkahdi', N'2', N'2', CAST(N'2021-12-29T18:02:33.953' AS DateTime))
INSERT [dbo].[PatientDemoInfo] ([Id], [PatientDemoInfoId], [User_Id], [title], [fname], [lname], [dob], [age], [race], [ethinicity], [languagesKnown], [email], [gender], [homeAddress], [contactNumber], [emergencyFname], [emergencyLname], [relationship], [emergencyEmail], [EmergencyMobileNo], [emergencyAddress], [portalaccess], [TypeofAllergies], [createdDate]) VALUES (2, 4, 2, N'Mr', N'Atish', N'Langote', CAST(N'2000-05-05T00:00:00.000' AS DateTime), N'26', N'Indian', N'Hindiu', N'Marathi', N'atish@gmail.com', N'Male', N'Barshi', N'2434343', N'skdks', N'nsdnkjs', N'Brother', N'ddjdjk@huhu.com', N'ciudsiusdh', N'nkjnkjsndks', N'No', N'dsjsjdjsd', CAST(N'2019-06-06T00:00:00.000' AS DateTime))
INSERT [dbo].[PatientDemoInfo] ([Id], [PatientDemoInfoId], [User_Id], [title], [fname], [lname], [dob], [age], [race], [ethinicity], [languagesKnown], [email], [gender], [homeAddress], [contactNumber], [emergencyFname], [emergencyLname], [relationship], [emergencyEmail], [EmergencyMobileNo], [emergencyAddress], [portalaccess], [TypeofAllergies], [createdDate]) VALUES (1, 6, 1, N'Mr', N'Abhimanyu', N'Patil', CAST(N'2000-03-03T00:00:00.000' AS DateTime), N'25', N'Indian', N'Hindu', N'Marathi', N'suraj@gmail.com', N'Male', N'Sangli', N'73278247328727', N'someone', N'soneone', N'Brother', N'someone@gmail.com', N'4732643264872462', N'kjsahdskhduhdkahdi', N'yes', N'jhdsuhsdiu', CAST(N'2021-05-23T00:00:00.000' AS DateTime))
INSERT [dbo].[PatientDemoInfo] ([Id], [PatientDemoInfoId], [User_Id], [title], [fname], [lname], [dob], [age], [race], [ethinicity], [languagesKnown], [email], [gender], [homeAddress], [contactNumber], [emergencyFname], [emergencyLname], [relationship], [emergencyEmail], [EmergencyMobileNo], [emergencyAddress], [portalaccess], [TypeofAllergies], [createdDate]) VALUES (NULL, 7, 5, N'1', N'anil', N'yadav', CAST(N'2021-11-30T18:30:00.000' AS DateTime), N'25', N'white', N'test', N'english', N'anil.yadav@gmal.com', N'Male', N'mumbai', N'6538378387', N'ramesh', N'yadav', N'Brother', N'ramesh.yadav@gmail.com', N'7567375736', N'', N'', NULL, NULL)
INSERT [dbo].[PatientDemoInfo] ([Id], [PatientDemoInfoId], [User_Id], [title], [fname], [lname], [dob], [age], [race], [ethinicity], [languagesKnown], [email], [gender], [homeAddress], [contactNumber], [emergencyFname], [emergencyLname], [relationship], [emergencyEmail], [EmergencyMobileNo], [emergencyAddress], [portalaccess], [TypeofAllergies], [createdDate]) VALUES (NULL, 8, 5, N'2', N'rani', N'sharma', CAST(N'2021-12-08T18:30:00.000' AS DateTime), N'34', N'white', N'test', N'english', N'anil.yadav@gmal.com', N'4', N'mumbai', N'6538378387', N'ramesh', N'yadav', N'Brother', N'ramesh.yadav@gmail.com', N'7567375736', N'mumbai', N'1', NULL, NULL)
INSERT [dbo].[PatientDemoInfo] ([Id], [PatientDemoInfoId], [User_Id], [title], [fname], [lname], [dob], [age], [race], [ethinicity], [languagesKnown], [email], [gender], [homeAddress], [contactNumber], [emergencyFname], [emergencyLname], [relationship], [emergencyEmail], [EmergencyMobileNo], [emergencyAddress], [portalaccess], [TypeofAllergies], [createdDate]) VALUES (NULL, 9, 5, N'1', N'akshay', N'dubey', CAST(N'2021-12-20T18:30:00.000' AS DateTime), N'25', N'white', N'test', N'english', N'akshay.dubey@gmail.com', N'Male', N'navi mumbai', N'6538378387', N'prasad', N'dubey', N'Brother', N'prasad.dubey@gmal.com', N'7567375736', N'navi mumbai', N'2', NULL, NULL)
SET IDENTITY_INSERT [dbo].[PatientDemoInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[PatientDiagnosisInfo] ON 

INSERT [dbo].[PatientDiagnosisInfo] ([Id], [PatientDiagnosisInfoId], [DiagnosisCode], [DiagnosisDescription], [DiagnosisIsDepricated], [Patient_Id], [Physician_Id], [Created_By]) VALUES (1, 1, N'A00', N'Drug', N'test', 20, 4, 5)
INSERT [dbo].[PatientDiagnosisInfo] ([Id], [PatientDiagnosisInfoId], [DiagnosisCode], [DiagnosisDescription], [DiagnosisIsDepricated], [Patient_Id], [Physician_Id], [Created_By]) VALUES (NULL, 2, N'A00', N'Typhoid', NULL, 20, 4, 5)
INSERT [dbo].[PatientDiagnosisInfo] ([Id], [PatientDiagnosisInfoId], [DiagnosisCode], [DiagnosisDescription], [DiagnosisIsDepricated], [Patient_Id], [Physician_Id], [Created_By]) VALUES (NULL, 3, N'A00', N'Cholera ', NULL, 20, 4, 5)
INSERT [dbo].[PatientDiagnosisInfo] ([Id], [PatientDiagnosisInfoId], [DiagnosisCode], [DiagnosisDescription], [DiagnosisIsDepricated], [Patient_Id], [Physician_Id], [Created_By]) VALUES (NULL, 4, N'A00', N'Cholera ', NULL, 20, 4, 5)
INSERT [dbo].[PatientDiagnosisInfo] ([Id], [PatientDiagnosisInfoId], [DiagnosisCode], [DiagnosisDescription], [DiagnosisIsDepricated], [Patient_Id], [Physician_Id], [Created_By]) VALUES (NULL, 5, N'A00', N'Cholera ', NULL, 20, 4, 5)
SET IDENTITY_INSERT [dbo].[PatientDiagnosisInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[PatientMedicationInfo] ON 

INSERT [dbo].[PatientMedicationInfo] ([Id], [PatientMedicationInfoId], [Drug_ID], [Drug_Name], [Drug_Generic_Name], [Drug_Brand_Name], [Drug_Form], [Drug_Strength], [Patient_Id], [Physician_Id], [Created_By]) VALUES (NULL, 1, N'', N'Paracetamol', N'calpol tab', NULL, N'tablet', N'350 mg', NULL, NULL, NULL)
INSERT [dbo].[PatientMedicationInfo] ([Id], [PatientMedicationInfoId], [Drug_ID], [Drug_Name], [Drug_Generic_Name], [Drug_Brand_Name], [Drug_Form], [Drug_Strength], [Patient_Id], [Physician_Id], [Created_By]) VALUES (NULL, 2, N'', N'cetrizine', N'okacet', NULL, N'tablet', N'10 mg', NULL, NULL, NULL)
INSERT [dbo].[PatientMedicationInfo] ([Id], [PatientMedicationInfoId], [Drug_ID], [Drug_Name], [Drug_Generic_Name], [Drug_Brand_Name], [Drug_Form], [Drug_Strength], [Patient_Id], [Physician_Id], [Created_By]) VALUES (NULL, 3, N'CT001', N'Paracetamol', N'calpol tab', NULL, N'tablet', N'350 mg', NULL, NULL, NULL)
INSERT [dbo].[PatientMedicationInfo] ([Id], [PatientMedicationInfoId], [Drug_ID], [Drug_Name], [Drug_Generic_Name], [Drug_Brand_Name], [Drug_Form], [Drug_Strength], [Patient_Id], [Physician_Id], [Created_By]) VALUES (NULL, 4, N'CT001', N'Paracetamol', N'calpol tab', NULL, N'tablet', N'350 mg', NULL, NULL, NULL)
INSERT [dbo].[PatientMedicationInfo] ([Id], [PatientMedicationInfoId], [Drug_ID], [Drug_Name], [Drug_Generic_Name], [Drug_Brand_Name], [Drug_Form], [Drug_Strength], [Patient_Id], [Physician_Id], [Created_By]) VALUES (NULL, 5, N'CT001', N'Paracetamol', N'calpol tab', NULL, N'tablet', N'350 mg', NULL, NULL, NULL)
INSERT [dbo].[PatientMedicationInfo] ([Id], [PatientMedicationInfoId], [Drug_ID], [Drug_Name], [Drug_Generic_Name], [Drug_Brand_Name], [Drug_Form], [Drug_Strength], [Patient_Id], [Physician_Id], [Created_By]) VALUES (NULL, 6, N'CT001', N'Paracetamol', N'calpol tab', NULL, N'tablet', N'350 mg', 20, 4, 5)
INSERT [dbo].[PatientMedicationInfo] ([Id], [PatientMedicationInfoId], [Drug_ID], [Drug_Name], [Drug_Generic_Name], [Drug_Brand_Name], [Drug_Form], [Drug_Strength], [Patient_Id], [Physician_Id], [Created_By]) VALUES (NULL, 8, N'CT001', N'Paracetamol', N'calpol tab', NULL, N'tablet', N'350 mg', 27, 4, 26)
SET IDENTITY_INSERT [dbo].[PatientMedicationInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[PatientProcedureInfo] ON 

INSERT [dbo].[PatientProcedureInfo] ([Id], [PatientProcedureInfoId], [ProcedureCode], [Patient_Id], [Physician_Id], [Created_By], [ProcedureIsDepricated], [ProcedureDescription]) VALUES (1, 9, N'0016070 ', 1, 2, 1, N'No', NULL)
INSERT [dbo].[PatientProcedureInfo] ([Id], [PatientProcedureInfoId], [ProcedureCode], [Patient_Id], [Physician_Id], [Created_By], [ProcedureIsDepricated], [ProcedureDescription]) VALUES (2, 10, N'0016071 ', 2, 2, 2, N'yes', NULL)
INSERT [dbo].[PatientProcedureInfo] ([Id], [PatientProcedureInfoId], [ProcedureCode], [Patient_Id], [Physician_Id], [Created_By], [ProcedureIsDepricated], [ProcedureDescription]) VALUES (2, 11, N'0016071 ', 2, 2, 2, N'yes', N'Bypass Cerebral Ventricle to Nasopharynx with Autologous Tissue Substitute, Open Approach')
INSERT [dbo].[PatientProcedureInfo] ([Id], [PatientProcedureInfoId], [ProcedureCode], [Patient_Id], [Physician_Id], [Created_By], [ProcedureIsDepricated], [ProcedureDescription]) VALUES (NULL, 12, N'0016070 ', 20, 4, 2, N'', N'Bypass Cerebral Ventricle to Nasopharynx with Autologous Tissue Substitute, Open Approach')
INSERT [dbo].[PatientProcedureInfo] ([Id], [PatientProcedureInfoId], [ProcedureCode], [Patient_Id], [Physician_Id], [Created_By], [ProcedureIsDepricated], [ProcedureDescription]) VALUES (NULL, 13, N'0016070 ', 20, 4, 2, N'Yes', N'Bypass Cerebral Ventricle to Nasopharynx with Autologous Tissue Substitute, Open Approach')
INSERT [dbo].[PatientProcedureInfo] ([Id], [PatientProcedureInfoId], [ProcedureCode], [Patient_Id], [Physician_Id], [Created_By], [ProcedureIsDepricated], [ProcedureDescription]) VALUES (NULL, 14, NULL, 20, 14, 2, NULL, NULL)
INSERT [dbo].[PatientProcedureInfo] ([Id], [PatientProcedureInfoId], [ProcedureCode], [Patient_Id], [Physician_Id], [Created_By], [ProcedureIsDepricated], [ProcedureDescription]) VALUES (NULL, 15, N'0016070 ', 20, 4, 2, N'Yes', N'Bypass Cerebral Ventricle to Nasopharynx with Autologous Tissue Substitute, Open Approach')
INSERT [dbo].[PatientProcedureInfo] ([Id], [PatientProcedureInfoId], [ProcedureCode], [Patient_Id], [Physician_Id], [Created_By], [ProcedureIsDepricated], [ProcedureDescription]) VALUES (NULL, 16, N'0016070 ', 20, 4, 26, N'Yes', N'Bypass Cerebral Ventricle to Nasopharynx with Autologous Tissue Substitute, Open Approach')
SET IDENTITY_INSERT [dbo].[PatientProcedureInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[PatientVitalSignInfo] ON 

INSERT [dbo].[PatientVitalSignInfo] ([Id], [PatientVitalSignInfoId], [Height], [Weight], [BloodPressure], [BodyTemperature], [RespirationRate], [Patient_Id], [Physician_Id], [Created_By]) VALUES (1, 1, CAST(155 AS Decimal(18, 0)), CAST(56 AS Decimal(18, 0)), CAST(80 AS Decimal(18, 0)), CAST(98 AS Decimal(18, 0)), CAST(73 AS Decimal(18, 0)), 1, 1, 2)
INSERT [dbo].[PatientVitalSignInfo] ([Id], [PatientVitalSignInfoId], [Height], [Weight], [BloodPressure], [BodyTemperature], [RespirationRate], [Patient_Id], [Physician_Id], [Created_By]) VALUES (NULL, 2, CAST(165 AS Decimal(18, 0)), CAST(60 AS Decimal(18, 0)), CAST(80 AS Decimal(18, 0)), CAST(98 AS Decimal(18, 0)), CAST(73 AS Decimal(18, 0)), 2, 1, 2)
INSERT [dbo].[PatientVitalSignInfo] ([Id], [PatientVitalSignInfoId], [Height], [Weight], [BloodPressure], [BodyTemperature], [RespirationRate], [Patient_Id], [Physician_Id], [Created_By]) VALUES (NULL, 3, CAST(167 AS Decimal(18, 0)), CAST(65 AS Decimal(18, 0)), CAST(80 AS Decimal(18, 0)), CAST(98 AS Decimal(18, 0)), CAST(73 AS Decimal(18, 0)), 2, 1, 2)
INSERT [dbo].[PatientVitalSignInfo] ([Id], [PatientVitalSignInfoId], [Height], [Weight], [BloodPressure], [BodyTemperature], [RespirationRate], [Patient_Id], [Physician_Id], [Created_By]) VALUES (NULL, 4, CAST(167 AS Decimal(18, 0)), CAST(65 AS Decimal(18, 0)), CAST(80 AS Decimal(18, 0)), CAST(98 AS Decimal(18, 0)), CAST(73 AS Decimal(18, 0)), 2, 1, 2)
INSERT [dbo].[PatientVitalSignInfo] ([Id], [PatientVitalSignInfoId], [Height], [Weight], [BloodPressure], [BodyTemperature], [RespirationRate], [Patient_Id], [Physician_Id], [Created_By]) VALUES (NULL, 5, CAST(167 AS Decimal(18, 0)), CAST(65 AS Decimal(18, 0)), CAST(80 AS Decimal(18, 0)), CAST(98 AS Decimal(18, 0)), CAST(73 AS Decimal(18, 0)), 2, 1, 2)
SET IDENTITY_INSERT [dbo].[PatientVitalSignInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[ProcedureData] ON 

INSERT [dbo].[ProcedureData] ([Id], [ProcedureId], [ProcedureCode], [ProcedureIsDepricated], [ProcedureDescription]) VALUES (1, 1, N'0016070 ', N'No', N'Bypass Cerebral Ventricle to Nasopharynx with Autologous Tissue Substitute, Open Approach')
INSERT [dbo].[ProcedureData] ([Id], [ProcedureId], [ProcedureCode], [ProcedureIsDepricated], [ProcedureDescription]) VALUES (2, 2, N'0016071 ', N'No', N'Bypass Cerebral Ventricle to Mastoid Sinus with Autologous Tissue Substitute, Open Approach')
INSERT [dbo].[ProcedureData] ([Id], [ProcedureId], [ProcedureCode], [ProcedureIsDepricated], [ProcedureDescription]) VALUES (3, 3, N'0016072 ', N'No', N'Bypass Cerebral Ventricle to Atrium with Autologous Tissue Substitute, Open Approach')
INSERT [dbo].[ProcedureData] ([Id], [ProcedureId], [ProcedureCode], [ProcedureIsDepricated], [ProcedureDescription]) VALUES (4, 4, N'0016073 ', N'Yes', N'Bypass Cerebral Ventricle to Blood Vessel with Autologous Tissue Substitute, Open Approach')
SET IDENTITY_INSERT [dbo].[ProcedureData] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([Id], [Role_Id], [Role_Name]) VALUES (1, 1, N'Admin')
INSERT [dbo].[Role] ([Id], [Role_Id], [Role_Name]) VALUES (2, 2, N'Physician')
INSERT [dbo].[Role] ([Id], [Role_Id], [Role_Name]) VALUES (3, 3, N'Nurse')
INSERT [dbo].[Role] ([Id], [Role_Id], [Role_Name]) VALUES (4, 4, N'Patient')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Scheduling] ON 

INSERT [dbo].[Scheduling] ([Scheduling_Id], [MeetingTitle], [DescriptiveInformation], [DateOfAppointment], [TimeOfAppointment], [Patient_Id], [Physician_Id], [Created_By]) VALUES (3, N'Brain Opertion', N'Brain Tumor', CAST(N'2016-11-10T00:00:00.000' AS DateTime), N'10:30', NULL, NULL, NULL)
INSERT [dbo].[Scheduling] ([Scheduling_Id], [MeetingTitle], [DescriptiveInformation], [DateOfAppointment], [TimeOfAppointment], [Patient_Id], [Physician_Id], [Created_By]) VALUES (4, N'Fever', N'Fever cold', CAST(N'2016-09-10T00:00:00.000' AS DateTime), N'11:30', NULL, NULL, NULL)
INSERT [dbo].[Scheduling] ([Scheduling_Id], [MeetingTitle], [DescriptiveInformation], [DateOfAppointment], [TimeOfAppointment], [Patient_Id], [Physician_Id], [Created_By]) VALUES (6, N'Eye 1 Opertion', N'Blindnes of 1 eye ', CAST(N'2018-08-10T00:00:00.000' AS DateTime), N'8:30', NULL, NULL, NULL)
INSERT [dbo].[Scheduling] ([Scheduling_Id], [MeetingTitle], [DescriptiveInformation], [DateOfAppointment], [TimeOfAppointment], [Patient_Id], [Physician_Id], [Created_By]) VALUES (8, N'Omicron Positive Treatment', N'Omicron Positive Treatment at 2 pm', CAST(N'2012-01-11T00:00:00.000' AS DateTime), N'2:00', NULL, NULL, NULL)
INSERT [dbo].[Scheduling] ([Scheduling_Id], [MeetingTitle], [DescriptiveInformation], [DateOfAppointment], [TimeOfAppointment], [Patient_Id], [Physician_Id], [Created_By]) VALUES (11, N'Angular Meeting updated', N'Meeting time at 11am', CAST(N'2021-12-01T00:00:00.000' AS DateTime), N'12:00 pm - 1:00 pm', NULL, NULL, NULL)
INSERT [dbo].[Scheduling] ([Scheduling_Id], [MeetingTitle], [DescriptiveInformation], [DateOfAppointment], [TimeOfAppointment], [Patient_Id], [Physician_Id], [Created_By]) VALUES (12, N'Meeting for leg operation at 3pm ', NULL, CAST(N'2021-12-13T00:00:00.000' AS DateTime), N'2:00 pm - 3:00 pm', NULL, NULL, NULL)
INSERT [dbo].[Scheduling] ([Scheduling_Id], [MeetingTitle], [DescriptiveInformation], [DateOfAppointment], [TimeOfAppointment], [Patient_Id], [Physician_Id], [Created_By]) VALUES (13, N'ABC suraj sharma', NULL, CAST(N'2021-12-21T00:00:00.000' AS DateTime), N'11:00 am - 12:00 pm', NULL, NULL, NULL)
INSERT [dbo].[Scheduling] ([Scheduling_Id], [MeetingTitle], [DescriptiveInformation], [DateOfAppointment], [TimeOfAppointment], [Patient_Id], [Physician_Id], [Created_By]) VALUES (14, N'Meeting 3', NULL, CAST(N'2021-12-21T00:00:00.000' AS DateTime), N'2:00 pm - 3:00 pm', NULL, 5, 4)
INSERT [dbo].[Scheduling] ([Scheduling_Id], [MeetingTitle], [DescriptiveInformation], [DateOfAppointment], [TimeOfAppointment], [Patient_Id], [Physician_Id], [Created_By]) VALUES (15, N'Meeting 4', NULL, CAST(N'2021-12-04T00:00:00.000' AS DateTime), N'9:00 am - 10:00 am', NULL, 5, NULL)
INSERT [dbo].[Scheduling] ([Scheduling_Id], [MeetingTitle], [DescriptiveInformation], [DateOfAppointment], [TimeOfAppointment], [Patient_Id], [Physician_Id], [Created_By]) VALUES (16, N'Meeting 5', NULL, CAST(N'2021-12-05T00:00:00.000' AS DateTime), N'10:00 am - 11:00 am', NULL, 5, NULL)
INSERT [dbo].[Scheduling] ([Scheduling_Id], [MeetingTitle], [DescriptiveInformation], [DateOfAppointment], [TimeOfAppointment], [Patient_Id], [Physician_Id], [Created_By]) VALUES (17, N'Meeting Nurse Appointment Create', N'Meeting Nurse Appointment Create with manisha', CAST(N'2021-12-03T00:00:00.000' AS DateTime), N'11:00 am - 12:00 pm', NULL, NULL, NULL)
INSERT [dbo].[Scheduling] ([Scheduling_Id], [MeetingTitle], [DescriptiveInformation], [DateOfAppointment], [TimeOfAppointment], [Patient_Id], [Physician_Id], [Created_By]) VALUES (18, N'Meeting Schedule By Nurse1 ', N'Meeting Schedule By Nurse1 for fever ', CAST(N'2021-12-12T00:00:00.000' AS DateTime), N'11:00 am - 12:00 pm', NULL, NULL, NULL)
INSERT [dbo].[Scheduling] ([Scheduling_Id], [MeetingTitle], [DescriptiveInformation], [DateOfAppointment], [TimeOfAppointment], [Patient_Id], [Physician_Id], [Created_By]) VALUES (19, N'Meeting with Nurse 2 ', N'Meeting with Nurse 2 due to cold fever ', CAST(N'2021-12-16T00:00:00.000' AS DateTime), N'12:00 pm - 1:00 pm', 4, 3, NULL)
INSERT [dbo].[Scheduling] ([Scheduling_Id], [MeetingTitle], [DescriptiveInformation], [DateOfAppointment], [TimeOfAppointment], [Patient_Id], [Physician_Id], [Created_By]) VALUES (20, N'Meeting 6', NULL, CAST(N'2021-12-22T00:00:00.000' AS DateTime), N'2:00 pm - 3:00 pm', NULL, 3, 4)
INSERT [dbo].[Scheduling] ([Scheduling_Id], [MeetingTitle], [DescriptiveInformation], [DateOfAppointment], [TimeOfAppointment], [Patient_Id], [Physician_Id], [Created_By]) VALUES (22, N'Umang 1', NULL, CAST(N'2021-12-27T00:00:00.000' AS DateTime), N'1:00 pm - 2:00 pm', 4, 3, 4)
INSERT [dbo].[Scheduling] ([Scheduling_Id], [MeetingTitle], [DescriptiveInformation], [DateOfAppointment], [TimeOfAppointment], [Patient_Id], [Physician_Id], [Created_By]) VALUES (23, N'test meeting  121', NULL, CAST(N'2021-12-30T00:00:00.000' AS DateTime), N'10:00 am - 11:00 am', 27, 16, 27)
INSERT [dbo].[Scheduling] ([Scheduling_Id], [MeetingTitle], [DescriptiveInformation], [DateOfAppointment], [TimeOfAppointment], [Patient_Id], [Physician_Id], [Created_By]) VALUES (24, N'meeting 1234', N'test desc1', CAST(N'2021-12-07T00:00:00.000' AS DateTime), N'10:00 am - 11:00 am', 20, 16, NULL)
SET IDENTITY_INSERT [dbo].[Scheduling] OFF
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD FOREIGN KEY([Role_Id])
REFERENCES [dbo].[Role] ([Role_Id])
GO
ALTER TABLE [dbo].[PatientDiagnosisInfo]  WITH CHECK ADD FOREIGN KEY([Created_By])
REFERENCES [dbo].[Login] ([User_Id])
GO
ALTER TABLE [dbo].[PatientDiagnosisInfo]  WITH CHECK ADD FOREIGN KEY([Patient_Id])
REFERENCES [dbo].[Login] ([User_Id])
GO
ALTER TABLE [dbo].[PatientDiagnosisInfo]  WITH CHECK ADD FOREIGN KEY([Physician_Id])
REFERENCES [dbo].[Login] ([User_Id])
GO
ALTER TABLE [dbo].[PatientMedicationInfo]  WITH CHECK ADD FOREIGN KEY([Created_By])
REFERENCES [dbo].[Login] ([User_Id])
GO
ALTER TABLE [dbo].[PatientMedicationInfo]  WITH CHECK ADD FOREIGN KEY([Patient_Id])
REFERENCES [dbo].[Login] ([User_Id])
GO
ALTER TABLE [dbo].[PatientMedicationInfo]  WITH CHECK ADD FOREIGN KEY([Physician_Id])
REFERENCES [dbo].[Login] ([User_Id])
GO
ALTER TABLE [dbo].[PatientProcedureInfo]  WITH CHECK ADD FOREIGN KEY([Created_By])
REFERENCES [dbo].[Login] ([User_Id])
GO
ALTER TABLE [dbo].[PatientProcedureInfo]  WITH CHECK ADD FOREIGN KEY([Patient_Id])
REFERENCES [dbo].[Login] ([User_Id])
GO
ALTER TABLE [dbo].[PatientVitalSignInfo]  WITH CHECK ADD FOREIGN KEY([Created_By])
REFERENCES [dbo].[Login] ([User_Id])
GO
ALTER TABLE [dbo].[PatientVitalSignInfo]  WITH CHECK ADD FOREIGN KEY([Patient_Id])
REFERENCES [dbo].[Login] ([User_Id])
GO
ALTER TABLE [dbo].[PatientVitalSignInfo]  WITH CHECK ADD FOREIGN KEY([Physician_Id])
REFERENCES [dbo].[Login] ([User_Id])
GO
ALTER TABLE [dbo].[Scheduling]  WITH CHECK ADD FOREIGN KEY([Created_By])
REFERENCES [dbo].[Login] ([User_Id])
GO
ALTER TABLE [dbo].[Scheduling]  WITH CHECK ADD FOREIGN KEY([Patient_Id])
REFERENCES [dbo].[Login] ([User_Id])
GO
ALTER TABLE [dbo].[Scheduling]  WITH CHECK ADD FOREIGN KEY([Physician_Id])
REFERENCES [dbo].[Login] ([User_Id])
GO
