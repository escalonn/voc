<header>

<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous">

<!-- Latest compiled and minified CSS -->
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

<link rel="stylesheet" href="https://bootswatch.com/4/cerulean/bootstrap.css" media="screen">
<link rel="stylesheet" href="https://bootswatch.com/_assets/css/custom.min.css">

<link rel="stylesheet" href="./vocareum.css">

<!-- Latest compiled and minified JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

<script type="text/javascript" src="./vocareum.js" ></script>

</header>


# Full Stack Lab

> NOTE: Data in /home/labsuser area is persistent.  All other directories are cleaned up after your session.

### This lab contains a full set of tools, software packages, frameworks, and databases, including - 

|  |  | 
| ------ | ----- | 
| Ubuntu 18.04 | Eclipse Theia | 
| Linux xfce desktop | Python 3.7 | 
| Java OpenJdk 14 | Node.js +Angular, React, Express | 
| Jenkins | Postman | 
| Wireshark | Springboot | 
| Tomcat | Jmeter |
| SonarQube | .NET | 
| Elastisearch | Logstash | 
| Kibana | Visual Studio | 
| Netbeans | Intellij | 
| Mongodb | Postgresql | 
| Mysql | AWS boto3 |



<br/>
<br/>
___

# Markdown Documentation Example:

# h1 Heading 

Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Purus in mollis nunc sed id semper risus in hendrerit. Amet cursus sit amet dictum sit amet justo donec enim. 

**Vocareum** is a cloud lab platform built specifically for training, research and assessment. The overall architecture combines cost effective compute, powerful assessment capability, and integration into various learning workflows.

## h2 Heading 
Our labs are delivered through the browser and have a flexible infrastructure to support a range of use cases including interactive computing (via notebooks), Cloud Computing, cyber security, programming, etc. Our labs are deployed in various learning contexts including MOOCs, large residential courses, bootcamps, and instructor-led corporate training, etc.  

### h3 Heading 
Vocareum Labs scale to *hundreds of thousands of concurrent learners*.

## Images

Here we are embedding an image ... 

![Sample Image](https://www.vocareum.com/wp-content/uploads/2017/05/VocareumLogo340x52-300x46.png)


## Unordered Lists

+ Key customers include:

  * **Canvas, Arizona State**: teamed up with Vocareum to support Hour Of Code professional development
  + **AWS**: AWS Educate Starter Account & Classroom Program, AWS Academy, AWS re:Invent
  - **EdX**: Vocareum Labs at MOOC-scale (Georgia Tech, Columbia, etc)
  + **Columbia University**: Applied Math - Jupyter Notebook
  + **Singapore University**: Computer Science - Flipped Classroom + Exam Management
  + **Northwestern/Kellogg**:  Data Analytics + Jupyter Notebook 


## Ordered Lists

+ Features

  1. Role Management: Org administrator, Content Owners, Instructors, Learners, Teams, Researchers
  1. Content Mgmt: Set ownership, distribution and access policies
  1. Lab Management: Set budgets, policies and limits
  1. Automated Scoring: Write scripts to support rubric-based assessments
  1. Exam Management: Secured & timed exams, w/ proctoring and auto-scoring
  1. Team Projects: Support projects in a shared workspace
  1. Gamification: Automatically rank user submissions and place on leaderboard
  1. Cloud IDE: Full-featured code editor and execution; no installation necessary

## Start numbering with offset:

+ Features (cont)

  57. Hosted Notebook: Jupyter Notebook and RStudio hosted in Vocareum cloud
  1. Cloud Resources: Deploy your own dedicated clusters, databases, etc. 
  1. Integrations: Integrated to all popular LMS platform via LTI; custom integrations via API; SAML
  1. Compliance: Compliant to FERPA and WCAG 2.0 AA Standards


## Tables

| Our Labs | Description | 
| ------ | ----------- |
| Machine Learning | Any ML framework; Develop & train models; Dedicated GPU; Evaluate results |
| Cloud Computing   | Policy controlled, budgeted; User or group accounts; Aggressive resource mgmt |
| Dev Ops  | Range of tools and infrastructure; Build and deploy; Linux; Sudo/Root/Admin |
| Big Data    | Hadoop processing; Predictive analysis on statistical models;Run MapR on Clusters; Access data sources |
| Interactive Notebook | Fully hosted solution; Pre-installed packages; Autograding / nbgrader; HPC: GPU, Cluster |
| Programming | Broad range of languages; Pre-installed packages; Linux terminal; IDE: standard, spyder, eclipse. |
| Ubuntu 18.04 | Eclipse Theia | 
| Linux xfce desktop | Python 3.7 | 
| Java OpenJdk 14 | Node.js ( +Angular, React, Express) |
| Jenkins | Postman | 
| Wireshark | Springboot | 
| Tomcat | Jmeter |
| SonarQube | .NET | 
| Elastisearch | Logstash | 
| Kibana | Visual Studio | 
| Netbeans | Intellij | 
| Mongodb | Postgresql | 
| Mysql | AWS boto3 |



## Blockquotes

> We were attracted to Vocareum because it offers an extensive set of utilities built on top of AWS, giving us the flexibility to configure a cost-effective computing hub for the diverse tools we’ll be teaching across our Data Science program.
>> Steven Buechler, University of Notre Dame 

## Forms & Answers

1. How would you imporve this lab?  

<textarea class="voc_textarea" id="voc-1" name="voc-1" onblur="vocOnBlur(event);" rows="3" cols="100" maxlength="500"></textarea> 
<div class="voc_answers">Offer more interactive content. Provide examples. </div>

2. How would you use radio buttons in your lab?

  <input onblur="saveAllData();" class="voc_radio" type="radio" id="q4-5-1-1" name="q4-5-1" value="1">Collect student input</input></p>
  <input onblur="saveAllData();" class="voc_radio" type="radio" id="q4-5-1-2" name="q4-5-1" value="2">Check student progress</input></p>
  <input onblur="saveAllData();" class="voc_radio" type="radio" id="q4-5-1-3" name="q4-5-1" value="3">Not sure yet</input></p>
  <div class="voc_answers">All answers are valid.</div>

<br/>
<br/>
<button onClick="toggleAnswers();">Show Answers</button>

## Links

[link text](http://www.vocareum.com)

Autoconverted link https://www.vocareum.com



## Code

Inline `code`

Indented code

    // Some comments
    line 1 of code
    line 2 of code
    line 3 of code


Block code "fences"

```
Sample text here...
```


## Horizontal Rule

___



## Emphasis

**This is bold text**

*This is italic text*

~~Strikethrough~~

## STOP

You have successfully completed this lab.

