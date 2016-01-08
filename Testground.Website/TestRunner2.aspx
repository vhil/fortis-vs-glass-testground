﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestRunner2.aspx.cs" Inherits="Testground.Website.TestRunner2" %>

<%@ Import Namespace="Testground.Website" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <title></title>
    <script src="/js/Chart.js"></script>
    <script src="/js/init.js"></script>
</head>
<body>
    <sc:Placeholder runat="server" Key="webedit"/>
        <div>
            <h3>Rendering Test Results</h3>
            <p>Item Count: <%=Const.ItemCount %></p>
            <div style="width: 50%">
                <canvas id="rendering-canvas" height="450" width="600"></canvas>
                <div style="margin-left: 38px; text-align: center;">
                    <div style="float: left; padding: 4px; width: 60px; background-color: rgba(200,0,0,0.8)">Sitecore</div>
                    <div style="float: left; padding: 4px; width: 60px; background-color: rgba(0,100,200,0.8)">Fortis</div>
                    <div style="float: left; padding: 4px; width: 60px; background-color: rgba(250,180,0,0.8)">Glass</div>
                </div>
            </div>
        </div>
         <div>
            <h3>Field Test Results</h3>
            <p>Item Count: <%=Const.ItemCount %></p>
            <div style="width: 50%">
                <canvas id="fields-canvas" height="450" width="600"></canvas>
                <div style="margin-left: 38px; text-align: center;">
                    <div style="float: left; padding: 4px; width: 60px; background-color: rgba(200,0,0,0.8)">Sitecore</div>
                    <div style="float: left; padding: 4px; width: 60px; background-color: rgba(0,100,200,0.8)">Fortis</div>
                    <div style="float: left; padding: 4px; width: 60px; background-color: rgba(250,180,0,0.8)">Glass</div>
                </div>
            </div>
        </div>
        <script>
            var renderingChartData = {
                labels: ["<%=string.Join("\", \"", this.RenderingResults.Select(x => x.CaseName))%>"],
                datasets: [
                    {
                        label: "Sitecore",
                        fillColor: "rgba(200,0,0,0.5)",
                        strokeColor: "rgba(200,0,0,0.8)",
                        highlightFill: "rgba(200,0,0,0.75)",
                        highlightStroke: "rgba(200,0,0,1)",
                        data: [<%=string.Join(", ", this.RenderingResults.Select(x => x.SitecoreResult))%>]
                 },
	            {
	                label: "Fortis",
	                fillColor: "rgba(0,100,200,0.5)",
	                strokeColor: "rgba(0,100,200,0.8)",
	                highlightFill: "rgba(0,100,200,0.75)",
	                highlightStroke: "rgba(0,100,200,1)",
	                data: [<%=string.Join(", ", this.RenderingResults.Select(x => x.FortisResult))%>]
	            },
	            {
	                label: "Glass",
	                fillColor: "rgba(250,180,0,0.5)",
	                strokeColor: "rgba(250,180,0,0.8)",
	                highlightFill: "rgba(250,180,0,0.75)",
	                highlightStroke: "rgba(250,180,0,1)",
	                data: [<%=string.Join(", ", this.RenderingResults.Select(x => x.GlassResult))%>]
	            }
             ]
            };

            var fieldChartData = {
                labels: ["<%=string.Join("\", \"", this.FieldResults.Select(x => x.CaseName))%>"],
                datasets: [
                    {
                        label: "Sitecore",
                        fillColor: "rgba(200,0,0,0.5)",
                        strokeColor: "rgba(200,0,0,0.8)",
                        highlightFill: "rgba(200,0,0,0.75)",
                        highlightStroke: "rgba(200,0,0,1)",
                        data: [<%=string.Join(", ", this.FieldResults.Select(x => x.SitecoreResult))%>]
	            },
	            {
	                label: "Fortis",
	                fillColor: "rgba(0,100,200,0.5)",
	                strokeColor: "rgba(0,100,200,0.8)",
	                highlightFill: "rgba(0,100,200,0.75)",
	                highlightStroke: "rgba(0,100,200,1)",
	                data: [<%=string.Join(", ", this.FieldResults.Select(x => x.FortisResult))%>]
	            },
	            {
	                label: "Glass",
	                fillColor: "rgba(250,180,0,0.5)",
	                strokeColor: "rgba(250,180,0,0.8)",
	                highlightFill: "rgba(250,180,0,0.75)",
	                highlightStroke: "rgba(250,180,0,1)",
	                data: [<%=string.Join(", ", this.FieldResults.Select(x => x.GlassResult))%>]
	            }
            ]
            };

            window.onload = initialize(renderingChartData, "rendering-canvas");
            window.onload = initialize(fieldChartData, "fields-canvas");
        </script>
</body>
</html>
