﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelevantCodes.ExtentReports.View
{
    public class Test
    {
        public static string Source
        {
            get
            {
                return @"
                        <li class='collection-item test displayed active @Model.Status.ToString().ToLower() @if(Model.ContainsChildNodes){ <del>hasChildren</del> }' extentid='@Model.ID'>
                            <div class='test-head'>
                                <span class='test-name'>@Model.Name</span>
                                <span class='test-status right label capitalize @Model.Status.ToString().ToLower()'>@Model.Status.ToString().ToLower()</span>
                                <span class='category-assigned hide'></span>
                            </div>
                            <div class='test-body'>
                                <div class='test-info'>
                                    <span title='Test started time' class='test-started-time label green lighten-2 text-white'>@Model.StartTime</span>
                                    <span title='Test ended time' class='test-ended-time label red lighten-2 text-white'>@Model.EndTime</span>
                                    <span title='Time taken to finish' class='test-time-taken label blue-grey lighten-3 text-white'>@Model.GetRunTime()</span>
                                </div>
                                <div class='test-desc'></div>
                                <div class='test-attributes'>
                                    @if (Model.CategoryList != null && Model.CategoryList.Count() > 0)
                                    {
                                        <div class='categories'>
                                        @foreach (var cat in Model.CategoryList)
                                        {
                                            <span class='category'>@cat.Name</span>
                                        }
                                        </div>
                                    }
                                    @if (Model.AuthorList != null && Model.AuthorList.Count() > 0)
                                    {
                                        <div class='authors'>
                                        @foreach (var author in Model.AuthorList)
                                        {
                                            <span class='author'>@author.Name</span>
                                        }
                                        </div>
                                    }
                                </div>
                                <div class='test-steps'>
                                    @if (Model.LogList != null && Model.LogList.Count() > 0)
                                    {
                                        <table class='bordered table-results'>
                                            <thead>
                                                <tr>
                                                    <th>Status</th>
                                                    <th>Timestamp</th>
                                                    @if (Model.LogList[0].StepName != null)
                                                    {
                                                        <th>StepName</th>
                                                    }
                                                    <th>Details</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                @foreach (var log in Model.LogList)
                                                {
                                                    <tr>
                                                        <td class='status @log.LogStatus.ToString().ToLower()'><i class='fa'></i>@log.LogStatus</td>" +
                                                        "<td class='timestamp'>@string.Format(\"{0:HH:mm:ss}\", log.Timestamp)</td>" +
                                                        @"@if (Model.LogList[0].StepName != null)
                                                        {
                                                            <td class='step-name'>@log.StepName</td>
                                                        }
                                                        <td class='step-details'>@log.Details</td>
                                                    </tr>
                                                }
                                            </tbody>
                                        </table>
                                    }
                                    <ul class='collapsible node-list' data-collapsible='accordion'>
                                        <!--%Node%-->
                                    </ul>
                                </div>
                            </div>
                        </li>".Replace("    ", "").Replace("\t", "").Replace("\r", "").Replace("\n", "");
            }
        }
    }
}