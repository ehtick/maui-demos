#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.ObjectModel;
using System.Globalization;

namespace SampleBrowser.Maui.CartesianChart.SfCartesianChart
{
    public class FinancialViewModel : BaseViewModel
    {      
        public ObservableCollection<ChartDataModel> StockData { get; set; }
        public ObservableCollection<ChartDataModel> StockDataOHLC { get; set; }

        public const string CandleSource = "12/31/2020\t97.07\t97.87\t95.78\t96.97\r\n12/30/2020\t96.95\t98.66\t96.55\t97.18\r\n12/29/2020\t98.87\t98.87\t94.7\t95.25\r\n12/28/2020\t100.03\t100.97\t98.2\t98.31\r\n12/24/2020\t98.69\t98.93\t97.11\t98.9\r\n12/23/2020\t98.12\t99.6\t97.08\t97.18\r\n12/22/2020\t98.35\t99.66\t97.64\t97.94\r\n12/21/2020\t97.22\t98.46\t96.4\t97.56\r\n12/18/2020\t101.22\t101.73\t98.12\t98.79\r\n12/17/2020\t101.29\t102.04\t98.91\t100.62\r\n12/16/2020\t101.2\t101.6\t98.12\t100.05\r\n12/15/2020\t104.41\t104.41\t99.85\t100.49\r\n12/14/2020\t99.57\t101.55\t98.92\t100.83\r\n12/11/2020\t96.81\t99.6\t96\t98.11\r\n12/10/2020\t96.74\t97.89\t95.64\t97.63\r\n12/9/2020\t103.16\t104.43\t96.43\t97.41\r\n12/8/2020\t99.71\t102.65\t99.68\t102.33\r\n12/7/2020\t101.49\t101.97\t99.83\t100.17\r\n12/4/2020\t98.08\t101.87\t98.08\t100.92\r\n12/3/2020\t100.57\t101.37\t97.66\t97.91\r\n12/2/2020\t100\t100.05\t98.12\t99.99\r\n12/1/2020\t97.54\t100.73\t97.25\t99.75\r\n11/30/2020\t97.38\t97.89\t95.42\t96.46\r\n11/27/2020\t94.5\t97.63\t94.5\t97.38\r\n11/25/2020\t97.4\t98.65\t94.2\t94.4\r\n11/24/2020\t95.85\t97.71\t94.24\t96.22\r\n11/23/2020\t91.03\t94.71\t90.8\t94.48\r\n11/20/2020\t89.08\t91.31\t89\t90.09\r\n11/19/2020\t88.35\t90.06\t88.17\t89.95\r\n11/18/2020\t89.31\t90.32\t88.09\t88.52\r\n11/17/2020\t88.76\t89.55\t87.5\t89.01\r\n11/16/2020\t87.63\t90.58\t87.33\t89.8\r\n11/13/2020\t86.15\t87.73\t85.59\t86.29\r\n11/12/2020\t86.28\t86.35\t83.55\t84.47\r\n11/11/2020\t85.35\t87.08\t85.35\t86.37\r\n11/10/2020\t86.61\t88.23\t83.5\t84.42\r\n11/9/2020\t85.99\t90.12\t85.24\t86.71\r\n11/6/2020\t84\t84.5\t82.02\t83.48\r\n11/5/2020\t79.98\t84.43\t79.39\t84.01\r\n11/4/2020\t72.82\t76.33\t71.72\t76.1\r\n11/3/2020\t69.72\t73.25\t69\t72.64\r\n11/2/2020\t68.61\t70.5\t68.34\t69.78\r\n10/30/2020\t68.21\t69.36\t66.71\t67.47\r\n10/29/2020\t67.11\t69.69\t66.23\t69.02\r\n10/28/2020\t68.29\t68.48\t66.65\t67.26\r\n10/27/2020\t69.71\t70.11\t68.95\t69.5\r\n10/26/2020\t71.51\t71.82\t68.57\t70.15\r\n10/23/2020\t73.28\t73.71\t72.28\t72.49\r\n10/22/2020\t72.64\t73.83\t72.08\t73.32\r\n10/21/2020\t73.01\t73.93\t72.28\t72.82\r\n10/20/2020\t73.95\t74.19\t72.34\t72.6\r\n10/19/2020\t73.69\t74.69\t72.87\t73.18\r\n10/16/2020\t72.87\t74.9\t72.22\t73.26\r\n10/15/2020\t70.87\t73.13\t68.53\t72.99\r\n10/14/2020\t72.54\t73.11\t71.29\t72.12\r\n10/13/2020\t71.77\t72.54\t71.28\t72.16\r\n10/12/2020\t71.23\t71.77\t70.11\t71.73\r\n10/9/2020\t69.16\t70.51\t68.47\t70.4\r\n10/8/2020\t67.79\t68.78\t67.38\t68\r\n10/7/2020\t66.73\t67.79\t66.09\t67.07\r\n10/6/2020\t66.62\t68.1\t64.72\t65.76\r\n10/5/2020\t62.39\t64.74\t62.39\t64.69\r\n10/2/2020\t62.4\t62.99\t61.68\t61.72\r\n10/1/2020\t63.68\t64.46\t63.16\t64.06\r\n9/30/2020\t62.78\t64.12\t62.11\t62.94\r\n9/29/2020\t62\t63.85\t62\t62.91\r\n9/28/2020\t60.93\t62.86\t60.43\t61.98\r\n9/25/2020\t59.01\t60.03\t58.56\t59.72\r\n9/24/2020\t57.64\t60.18\t57.04\t59.52\r\n9/23/2020\t59.38\t60.7\t57.85\t57.9\r\n9/22/2020\t58.88\t59.67\t57.69\t59.42\r\n9/21/2020\t57.42\t58.84\t57.09\t58.7\r\n9/18/2020\t60.9\t61.17\t58.15\t59.23\r\n9/17/2020\t58.42\t60.14\t57.85\t60.03\r\n9/16/2020\t61.2\t62.16\t59.81\t60.07\r\n9/15/2020\t61.14\t61.84\t60.43\t60.71\r\n9/14/2020\t59.88\t61.49\t59.79\t61.24\r\n9/11/2020\t58.66\t59.45\t58.32\t58.84\r\n9/10/2020\t60.54\t61.01\t57.81\t57.85\r\n9/9/2020\t60.49\t61.33\t58.65\t60.23\r\n9/8/2020\t66.74\t66.74\t59.33\t59.38\r\n9/4/2020\t73.72\t74.02\t66.79\t69.12\r\n9/3/2020\t75.3\t75.87\t73\t73.36\r\n9/2/2020\t74.67\t76.46\t73.93\t76.45\r\n9/1/2020\t74.21\t74.66\t73.21\t74.03\r\n8/31/2020\t75.69\t75.79\t74.12\t74.12\r\n8/28/2020\t74.16\t76.18\t74\t76.01\r\n8/27/2020\t75.89\t75.89\t73.06\t73.7\r\n8/26/2020\t75.64\t75.97\t74.6\t75.43\r\n8/25/2020\t75.88\t76.36\t74.48\t75.63\r\n8/24/2020\t76.13\t77.51\t74.45\t75.79\r\n8/21/2020\t75.79\t76.3\t73.85\t75.01\r\n8/20/2020\t77.84\t77.99\t75.63\t75.98\r\n8/19/2020\t79.46\t80.06\t78.51\t79.08\r\n8/18/2020\t81.44\t81.47\t79.06\t79.46\r\n8/17/2020\t80.74\t82.26\t80.62\t81.79\r\n8/14/2020\t79.67\t81.21\t79.51\t80.03\r\n8/13/2020\t79.75\t80.89\t78.87\t80.07\r\n8/12/2020\t78.47\t80.62\t78.22\t79.72\r\n8/11/2020\t79.82\t81.91\t77.47\t77.97\r\n8/10/2020\t78.69\t80.27\t77.61\t79.89\r\n8/7/2020\t76.6\t78.73\t75.87\t78.64\r\n8/6/2020\t79.49\t79.49\t74.91\t76.78\r\n8/5/2020\t79.45\t79.75\t75.17\t77.47\r\n8/4/2020\t74.47\t75.25\t74.3\t74.92\r\n8/3/2020\t74.15\t75.83\t73.82\t74.3\r\n7/31/2020\t71.9\t73.57\t70.58\t73.57\r\n7/30/2020\t68.44\t72.47\t68.44\t72.05\r\n7/29/2020\t69.01\t69.85\t68.82\t69.39\r\n7/28/2020\t70.16\t70.33\t68.21\t68.37\r\n7/27/2020\t69.19\t71.39\t69.19\t70.86\r\n7/24/2020\t71.05\t71.05\t68.51\t68.63\r\n7/23/2020\t70.75\t72.91\t70.49\t71.82\r\n7/22/2020\t70.09\t71.4\t70.09\t71.04\r\n7/21/2020\t72.04\t72.04\t69.58\t70.02\r\n7/20/2020\t70.4\t71.75\t70.25\t71.2\r\n7/17/2020\t70.54\t70.89\t69.69\t70.42\r\n7/16/2020\t69.89\t70.7\t68.83\t70.09\r\n7/15/2020\t71.62\t72.34\t68.63\t70.11\r\n7/14/2020\t68.81\t70.03\t67.04\t70.02\r\n7/13/2020\t70.24\t71.55\t68.82\t68.93\r\n7/10/2020\t70.12\t70.24\t68.16\t69.06\r\n7/9/2020\t69.89\t70.43\t68.28\t70.07\r\n7/8/2020\t66.4\t69.47\t66.4\t69.47\r\n7/7/2020\t67.92\t69.49\t67.2\t67.33\r\n7/6/2020\t68.69\t70.18\t68.42\t68.62\r\n7/2/2020\t67.29\t68.1\t66.46\t67.24\r\n7/1/2020\t67.89\t68.78\t65.71\t65.84\r\n6/30/2020\t65.49\t68.36\t65.36\t67.79\r\n6/29/2020\t63.57\t65.77\t62.63\t65.37\r\n6/26/2020\t65.8\t66.15\t62.59\t62.81\r\n6/25/2020\t64.42\t66.21\t62.92\t66.14\r\n6/24/2020\t66.1\t66.58\t64.64\t65.02\r\n6/23/2020\t67.97\t68.02\t66.3\t66.79\r\n6/22/2020\t66.15\t67.27\t65\t66.94\r\n6/19/2020\t67.68\t68.63\t66.32\t66.56\r\n6/18/2020\t65.99\t67.51\t65.99\t66.71\r\n6/17/2020\t68.19\t68.26\t66.33\t66.35\r\n6/16/2020\t67.58\t68.68\t65.94\t67.42\r\n6/15/2020\t62.24\t65.29\t61.58\t65\r\n6/12/2020\t64.64\t65.78\t63.01\t64.47\r\n6/11/2020\t65.76\t67.74\t61.25\t62.04\r\n6/10/2020\t70.26\t70.26\t67.91\t68.49\r\n6/9/2020\t69.57\t71.12\t69.21\t69.96\r\n6/8/2020\t73.33\t74\t70.5\t70.7\r\n6/5/2020\t73.59\t75.42\t72.78\t73\r\n6/4/2020\t69.49\t71.13\t69.02\t71.02\r\n6/3/2020\t68.2\t71.11\t67.75\t70.36\r\n6/2/2020\t66.5\t67.63\t65.95\t67.09\r\n6/1/2020\t66.69\t67.65\t66.18\t66.4\r\n5/29/2020\t64.79\t67.42\t64.59\t66.83\r\n5/28/2020\t66\t67.43\t64\t65.22\r\n5/27/2020\t65.94\t66.2\t62.78\t66.1\r\n5/26/2020\t64.94\t65.88\t63.43\t65.09\r\n5/22/2020\t62.65\t62.65\t61.38\t62.23\r\n5/21/2020\t64.54\t64.84\t62.41\t62.45\r\n5/20/2020\t63.72\t65.82\t63.72\t64.9\r\n5/19/2020\t61.6\t64.37\t61.03\t62.44\r\n5/18/2020\t61.02\t61.92\t59.5\t61.55\r\n5/15/2020\t58.84\t59.24\t57.6\t58.38\r\n5/14/2020\t57.31\t60.47\t55.56\t60.32\r\n5/13/2020\t59.76\t60.45\t57.84\t59.02\r\n5/12/2020\t63.22\t63.3\t60.46\t60.48\r\n5/11/2020\t61.7\t63.44\t61.08\t63.03\r\n5/8/2020\t60.45\t63.06\t60.45\t62.93\r\n5/7/2020\t61.23\t61.23\t59.12\t60\r\n5/6/2020\t56\t61.28\t55.87\t58.76\r\n5/5/2020\t54.19\t56.89\t54.05\t54.82\r\n5/4/2020\t52.34\t53.93\t51.06\t53.1\r\n5/1/2020\t54.26\t54.26\t49.85\t53.12\r\n4/30/2020\t57.58\t58.35\t55.56\t55.6\r\n4/29/2020\t53.94\t60.19\t53.17\t59.61\r\n4/28/2020\t52.29\t52.89\t50.46\t52.05\r\n4/27/2020\t49.77\t51.48\t49.22\t50.8\r\n4/24/2020\t48.88\t49.37\t47.82\t49.18\r\n4/23/2020\t49.61\t50.18\t47.7\t48.92\r\n4/22/2020\t49.36\t50.15\t48.09\t49.4\r\n4/21/2020\t49.5\t49.93\t46.98\t47.69\r\n4/20/2020\t51.68\t53.57\t51.38\t51.71\r\n4/17/2020\t52.18\t54.24\t50.82\t53.75\r\n4/16/2020\t50.24\t51.02\t48.66\t50.22\r\n4/15/2020\t50.53\t51.34\t49.04\t49.24\r\n4/14/2020\t52.57\t53.18\t50.43\t52.93\r\n4/13/2020\t50.88\t51.84\t49.98\t50.51\r\n4/9/2020\t51.74\t53.36\t50.19\t51.62\r\n4/8/2020\t52.11\t52.44\t49.59\t50.33\r\n4/7/2020\t51.04\t52.15\t49.27\t51.68\r\n4/6/2020\t45.3\t48.98\t45.3\t48.61\r\n4/3/2020\t45.38\t45.99\t41.78\t43.07\r\n4/2/2020\t43.08\t45.74\t43\t45.15\r\n4/1/2020\t45.9\t46.96\t43.56\t44.15\r\n3/31/2020\t49.79\t50.38\t46.62\t48.49\r\n3/30/2020\t50.19\t51.75\t48.98\t50.16\r\n3/27/2020\t52.93\t53.73\t49.14\t50.18\r\n3/26/2020\t46.78\t56.61\t45.49\t55.21\r\n3/25/2020\t44.4\t48.81\t42.04\t46.31\r\n3/24/2020\t41.33\t44.55\t38.67\t44.09\r\n3/23/2020\t35.34\t39.42\t34.78\t38.61\r\n3/20/2020\t39.27\t42.41\t34.43\t35.99\r\n3/19/2020\t35.32\t39.41\t33.42\t38.09\r\n3/18/2020\t42.36\t43.63\t33.38\t35.55\r\n3/17/2020\t41.08\t46.01\t39.21\t45.87\r\n3/16/2020\t40.63\t43.91\t40.04\t40.62\r\n3/13/2020\t46.28\t47.14\t41.31\t46.24\r\n3/12/2020\t47.54\t48.57\t43.52\t43.6\r\n3/11/2020\t53.72\t54.88\t51.2\t51.79\r\n3/10/2020\t56.57\t56.67\t53.12\t55.66\r\n3/9/2020\t58.52\t61.77\t54.22\t54.51\r\n3/6/2020\t59.6\t61.8\t59.28\t61.45\r\n3/5/2020\t61.5\t63.03\t60.76\t61.76\r\n3/4/2020\t60.41\t63.18\t59.84\t63.06\r\n3/3/2020\t59.79\t61.57\t58.51\t59.62\r\n3/2/2020\t59.73\t60.17\t57.81\t59.94\r\n2/28/2020\t57.17\t60.73\t57.05\t59.48\r\n2/27/2020\t58.4\t61.13\t57.82\t60.01\r\n2/26/2020\t60.9\t62.12\t60.35\t60.77\r\n2/25/2020\t63.55\t63.78\t59.96\t60.52\r\n2/24/2020\t64\t64.94\t62.49\t62.97\r\n2/21/2020\t68.84\t68.91\t66.59\t66.76\r\n2/20/2020\t70.53\t71.33\t68.59\t69.39\r\n2/19/2020\t73.12\t74.03\t70.28\t71.09\r\n2/18/2020\t76.94\t76.94\t71.42\t72\r\n2/14/2020\t78.01\t78.49\t75.95\t76.86\r\n2/13/2020\t76.16\t78.21\t75.72\t77.94\r\n2/12/2020\t75.62\t76.85\t75.11\t76.5\r\n2/11/2020\t72.54\t75.15\t72.09\t74.91\r\n2/10/2020\t70.53\t71.93\t70.21\t71.84\r\n2/7/2020\t72.47\t72.47\t70.4\t71.02\r\n2/6/2020\t73.68\t73.83\t72.69\t73.15\r\n2/5/2020\t74.05\t74.08\t72.44\t73.7\r\n2/4/2020\t72.5\t73.56\t71.8\t72.9\r\n2/3/2020\t70.35\t72.12\t70.35\t71.07\r\n1/31/2020\t72.53\t72.56\t69.69\t69.94\r\n1/30/2020\t72.76\t74\t71.48\t72.98\r\n1/29/2020\t73.4\t74.18\t72.33\t72.61\r\n1/28/2020\t72.33\t73.78\t71.1\t73.19\r\n1/27/2020\t72.78\t72.94\t71.12\t71.62\r\n1/24/2020\t77\t77.12\t74.64\t75.26\r\n1/23/2020\t75.66\t76.49\t75.01\t76.44\r\n1/22/2020\t76.52\t77.87\t75.01\t75.24\r\n1/21/2020\t74.18\t76.2\t74\t76.11\r\n1/17/2020\t74.9\t74.9\t73.03\t74.01\r\n1/16/2020\t73.88\t75.05\t73.83\t74.19\r\n1/15/2020\t73.18\t74.63\t72.74\t73.08\r\n1/14/2020\t71.9\t75.11\t71.3\t73.28\r\n1/13/2020\t70.97\t71.66\t70.5\t71.6\r\n1/10/2020\t71.75\t72.09\t70.45\t70.75\r\n1/9/2020\t71.42\t71.9\t71.09\t71.5\r\n1/8/2020\t71.09\t71.57\t70.79\t70.84\r\n1/7/2020\t69.67\t71.62\t69.21\t71.15\r\n1/6/2020\t70.55\t70.55\t69.59\t69.71\r\n1/3/2020\t70.24\t72.24\t70.21\t71.55\r\n1/2/2020\t72\t72.13\t70.52\t71.72\r\n";

        public const string OHLCSource = "12/29/2000\t15.47\t15.5\t15.31\t15.31\r\n12/28/2000\t15.41\t15.5\t15.41\t15.5\r\n12/27/2000\t15.41\t15.47\t15.25\t15.47\r\n12/26/2000\t15.94\t16\t15.5\t15.5\r\n12/22/2000\t15.28\t16.06\t15.28\t16.06\r\n12/21/2000\t15.38\t15.38\t15.13\t15.38\r\n12/20/2000\t15.5\t15.56\t15.19\t15.41\r\n12/19/2000\t15.41\t15.66\t15.09\t15.53\r\n12/18/2000\t15.25\t15.5\t15.25\t15.47\r\n12/15/2000\t15.28\t15.31\t15.09\t15.31\r\n12/14/2000\t15.41\t15.5\t15.31\t15.34\r\n12/13/2000\t15.22\t15.5\t15.22\t15.47\r\n12/12/2000\t15.25\t15.44\t15.25\t15.34\r\n12/11/2000\t15.13\t15.38\t15.13\t15.38\r\n12/8/2000\t14.88\t15.19\t14.88\t15.19\r\n12/7/2000\t14.75\t15\t14.75\t14.94\r\n12/6/2000\t14.81\t15\t14.81\t14.81\r\n12/5/2000\t14.19\t14.94\t14.13\t14.94\r\n12/4/2000\t14.41\t14.56\t14.25\t14.31\r\n12/1/2000\t14.16\t14.53\t14.16\t14.53\r\n11/30/2000\t14.31\t14.47\t14.28\t14.28\r\n11/29/2000\t14.13\t14.44\t14\t14.44\r\n11/28/2000\t14.28\t14.59\t14.25\t14.25\r\n11/27/2000\t14.63\t14.72\t14.41\t14.41\r\n11/24/2000\t14.59\t14.63\t14.59\t14.63\r\n11/22/2000\t14.63\t14.94\t14.63\t14.69\r\n11/21/2000\t14.56\t14.84\t14.56\t14.81\r\n11/20/2000\t14.84\t14.97\t14.72\t14.94\r\n11/17/2000\t14.94\t15\t14.78\t14.94\r\n11/16/2000\t14.81\t14.97\t14.72\t14.94\r\n11/15/2000\t14.31\t14.88\t14.31\t14.88\r\n11/14/2000\t14.41\t14.41\t14.22\t14.38\r\n11/13/2000\t14.19\t14.56\t14.13\t14.53\r\n11/10/2000\t14.44\t14.44\t14.16\t14.22\r\n11/9/2000\t14.25\t14.5\t14.09\t14.5\r\n11/8/2000\t14.16\t14.5\t14\t14.28\r\n11/7/2000\t14.03\t14.22\t13.94\t14.22\r\n11/6/2000\t13.91\t14.13\t13.88\t14.13\r\n11/3/2000\t14\t14\t13.81\t13.97\r\n11/2/2000\t13.81\t14\t13.78\t14\r\n11/1/2000\t13.91\t13.97\t13.81\t13.91\r\n10/31/2000\t13.59\t13.97\t13.59\t13.97\r\n10/30/2000\t13.41\t13.69\t13.41\t13.69\r\n10/27/2000\t13.44\t13.59\t13.44\t13.5\r\n10/26/2000\t13.31\t13.56\t13.31\t13.56\r\n10/25/2000\t13.28\t13.47\t13.28\t13.44\r\n10/24/2000\t13\t13.5\t13\t13.38\r\n10/23/2000\t12.91\t13.09\t12.91\t13.06\r\n10/20/2000\t12.84\t13\t12.84\t13\r\n10/19/2000\t12.84\t13\t12.75\t12.84\r\n10/18/2000\t12.84\t12.88\t12.84\t12.88\r\n10/17/2000\t12.84\t12.91\t12.78\t12.84\r\n10/16/2000\t13.16\t13.25\t12.97\t12.97\r\n10/13/2000\t13.13\t13.25\t13.06\t13.19\r\n10/12/2000\t13.19\t13.31\t13.06\t13.16\r\n10/11/2000\t12.97\t13.25\t12.97\t13.19\r\n10/10/2000\t13.25\t13.31\t13.19\t13.19\r\n10/9/2000\t13.5\t13.5\t13.25\t13.25\r\n10/6/2000\t13.75\t13.75\t13.47\t13.47\r\n10/5/2000\t13.38\t13.88\t13.38\t13.75\r\n10/4/2000\t13.44\t13.5\t13.38\t13.5\r\n10/3/2000\t13.41\t13.75\t13.41\t13.56\r\n10/2/2000\t13.47\t13.69\t13.41\t13.47\r\n9/29/2000\t13.41\t13.81\t13.38\t13.59\r\n9/28/2000\t13.28\t13.56\t13.28\t13.5\r\n9/27/2000\t13.28\t13.44\t13.25\t13.28\r\n9/26/2000\t13.84\t13.84\t13.25\t13.31\r\n9/25/2000\t13.75\t14\t13.75\t13.91\r\n9/22/2000\t13.47\t13.91\t13.41\t13.84\r\n9/21/2000\t13.41\t13.72\t13.41\t13.59\r\n9/20/2000\t13.69\t13.75\t13.44\t13.44\r\n9/19/2000\t13.19\t13.75\t13.13\t13.75\r\n9/18/2000\t13.38\t13.38\t13.13\t13.13\r\n9/15/2000\t13.16\t13.44\t13.16\t13.44\r\n9/14/2000\t13.06\t13.38\t13.06\t13.38\r\n9/13/2000\t13.44\t13.5\t13.03\t13.13\r\n9/12/2000\t13.5\t13.63\t13.44\t13.56\r\n9/11/2000\t13.34\t13.44\t13.13\t13.44\r\n9/8/2000\t13.38\t13.53\t13.38\t13.41\r\n9/7/2000\t13.19\t13.5\t13.19\t13.5\r\n9/6/2000\t13.06\t13.28\t13.03\t13.28\r\n9/5/2000\t13.22\t13.25\t13.09\t13.19\r\n9/1/2000\t13.44\t13.44\t13.25\t13.31\r\n8/31/2000\t13.84\t13.84\t13.47\t13.5\r\n8/30/2000\t13.63\t13.94\t13.5\t13.91\r\n8/29/2000\t13.47\t13.75\t13.47\t13.63\r\n8/28/2000\t13.34\t13.5\t13.28\t13.44\r\n8/25/2000\t13.13\t13.69\t13.13\t13.47\r\n8/24/2000\t12.72\t12.94\t12.66\t12.94\r\n8/23/2000\t12.91\t12.97\t12.75\t12.75\r\n8/22/2000\t12.88\t13.06\t12.81\t12.91\r\n8/21/2000\t12.94\t13.13\t12.88\t13\r\n8/18/2000\t12.72\t13\t12.72\t12.94\r\n8/17/2000\t12.94\t13\t12.75\t12.84\r\n8/16/2000\t12.75\t13.06\t12.69\t13.06\r\n8/15/2000\t12.81\t12.97\t12.78\t12.88\r\n8/14/2000\t12.84\t12.97\t12.75\t12.94\r\n8/11/2000\t12.78\t12.94\t12.78\t12.84\r\n8/10/2000\t12.69\t12.97\t12.69\t12.78\r\n8/9/2000\t12.63\t12.75\t12.56\t12.69\r\n8/8/2000\t12.63\t12.81\t12.56\t12.59\r\n8/7/2000\t12.06\t12.75\t12.06\t12.69\r\n8/4/2000\t12.13\t12.16\t12.06\t12.06\r\n8/3/2000\t12.44\t12.44\t12.13\t12.16\r\n8/2/2000\t12.22\t12.41\t11.97\t12.41\r\n8/1/2000\t12.88\t12.94\t12.16\t12.28\r\n7/31/2000\t12.56\t13\t12.56\t13\r\n7/28/2000\t12.38\t12.59\t12.25\t12.56\r\n7/27/2000\t12.53\t12.63\t12.28\t12.5\r\n7/26/2000\t12.28\t12.63\t12.19\t12.63\r\n7/25/2000\t12.5\t12.5\t12.16\t12.41\r\n7/24/2000\t12.63\t12.88\t12.56\t12.56\r\n7/21/2000\t12.84\t12.94\t12.56\t12.66\r\n7/20/2000\t12.63\t12.94\t12.63\t12.94\r\n7/19/2000\t12.94\t12.94\t12.78\t12.81\r\n7/18/2000\t12.81\t13.09\t12.81\t13\r\n7/17/2000\t12.66\t12.81\t12.44\t12.81\r\n7/14/2000\t12.47\t12.69\t12.41\t12.59\r\n7/13/2000\t12.25\t12.56\t12.22\t12.5\r\n7/12/2000\t11.81\t12.5\t11.75\t12.38\r\n7/11/2000\t11.75\t12\t11.75\t11.78\r\n7/10/2000\t11.94\t12\t11.75\t11.75\r\n7/7/2000\t11.91\t11.97\t11.53\t11.97\r\n7/6/2000\t11.75\t11.97\t10.88\t11.97\r\n7/5/2000\t11.91\t12.31\t11.88\t11.88\r\n7/3/2000\t11.63\t11.94\t11.53\t11.94\r\n6/30/2000\t12.19\t12.19\t11.5\t11.5\r\n6/29/2000\t12.5\t12.5\t12.13\t12.13\r\n6/28/2000\t12.16\t12.5\t12.06\t12.5\r\n6/27/2000\t12.25\t12.28\t12.06\t12.09\r\n6/26/2000\t12.28\t12.31\t12.13\t12.31\r\n6/23/2000\t12.41\t12.47\t12.28\t12.34\r\n6/22/2000\t12.25\t12.44\t12.19\t12.41\r\n6/21/2000\t12.06\t12.28\t12\t12.25\r\n6/20/2000\t12.19\t12.19\t12\t12.06\r\n6/19/2000\t12.19\t12.19\t11.94\t12.19\r\n6/16/2000\t12.81\t13\t12.03\t12.13\r\n6/15/2000\t12.56\t12.91\t12.5\t12.81\r\n6/14/2000\t12.5\t12.63\t12.44\t12.63\r\n6/13/2000\t11.81\t12.5\t11.81\t12.5\r\n6/12/2000\t12.28\t12.34\t11.81\t11.81\r\n6/9/2000\t12.53\t12.72\t12.28\t12.28\r\n6/8/2000\t12.28\t12.63\t12.22\t12.59\r\n6/7/2000\t11.97\t12.34\t11.94\t12.34\r\n6/6/2000\t12\t12\t11.84\t11.94\r\n6/5/2000\t11.59\t12\t11.59\t12\r\n6/2/2000\t11.81\t11.91\t11.63\t11.69\r\n6/1/2000\t11.59\t11.94\t11.34\t11.94\r\n5/31/2000\t11.59\t11.75\t11.47\t11.59\r\n5/30/2000\t11.56\t11.75\t11.5\t11.63\r\n5/26/2000\t11.63\t11.63\t11.47\t11.5\r\n5/25/2000\t11.34\t11.75\t11.34\t11.59\r\n5/24/2000\t11.19\t11.41\t11.13\t11.34\r\n5/23/2000\t11.88\t11.88\t10.94\t11.16\r\n5/22/2000\t11.41\t11.88\t11.34\t11.88\r\n5/19/2000\t11.16\t11.44\t11.09\t11.44\r\n5/18/2000\t11.75\t11.75\t11.13\t11.16\r\n5/17/2000\t11.97\t11.97\t11.66\t11.75\r\n5/16/2000\t12\t12\t11.81\t11.91\r\n5/15/2000\t11.88\t11.94\t11.66\t11.94\r\n5/12/2000\t11.97\t12\t11.88\t11.94\r\n5/11/2000\t11.81\t11.97\t11.72\t11.97\r\n5/10/2000\t12.19\t12.19\t11.81\t11.94\r\n5/9/2000\t12.38\t12.41\t12.16\t12.25\r\n5/8/2000\t12.5\t12.56\t12.38\t12.41\r\n5/5/2000\t12.56\t12.59\t12.44\t12.56\r\n5/4/2000\t12.53\t12.59\t12.53\t12.59\r\n5/3/2000\t12.63\t12.66\t12.56\t12.59\r\n5/2/2000\t12.66\t12.69\t12.56\t12.69\r\n5/1/2000\t12.59\t12.69\t12.56\t12.69\r\n4/28/2000\t12.56\t12.63\t12.53\t12.63\r\n4/27/2000\t12.5\t12.63\t12.44\t12.63\r\n4/26/2000\t12.56\t12.75\t12.56\t12.69\r\n4/25/2000\t12.34\t12.63\t12.3\t12.56\r\n4/24/2000\t12.19\t12.41\t12.06\t12.34\r\n4/20/2000\t11.88\t12.31\t11.88\t12.19\r\n4/19/2000\t11.94\t12.06\t11.81\t12\r\n4/18/2000\t11.63\t11.94\t11.56\t11.94\r\n4/17/2000\t11.78\t11.81\t11.53\t11.59\r\n4/14/2000\t11.81\t11.88\t11.75\t11.88\r\n4/13/2000\t11.84\t11.91\t11.75\t11.84\r\n4/12/2000\t11.69\t11.88\t11.66\t11.78\r\n4/11/2000\t11.63\t11.66\t11.53\t11.63\r\n4/10/2000\t11.66\t11.78\t11.47\t11.59\r\n4/7/2000\t11.5\t11.78\t11.5\t11.69\r\n4/6/2000\t11.19\t11.47\t11.16\t11.44\r\n4/5/2000\t11.53\t11.53\t11\t11.19\r\n4/4/2000\t11.91\t11.91\t11.31\t11.53\r\n4/3/2000\t11.75\t12.19\t11.75\t11.94\r\n3/31/2000\t12.28\t12.34\t11.75\t11.75\r\n3/30/2000\t12.25\t12.31\t12.16\t12.22\r\n3/29/2000\t12.91\t12.91\t12.25\t12.25\r\n3/28/2000\t12.72\t13.09\t12.66\t12.84\r\n3/27/2000\t13.13\t13.13\t11.97\t12.84\r\n3/24/2000\t13.97\t13.97\t13.19\t13.22\r\n3/23/2000\t13.69\t14\t13.63\t13.91\r\n3/22/2000\t13.75\t13.94\t13.5\t13.69\r\n3/21/2000\t13.25\t13.81\t13.19\t13.81\r\n3/20/2000\t13.09\t13.31\t13.06\t13.25\r\n3/17/2000\t13.16\t13.19\t13\t13.16\r\n3/16/2000\t13.13\t13.22\t13.09\t13.19\r\n3/15/2000\t13.13\t13.16\t13.06\t13.16\r\n3/14/2000\t12.91\t13.13\t12.84\t13.13\r\n3/13/2000\t13\t13\t12.69\t12.81\r\n3/10/2000\t12.97\t13.03\t12.91\t12.94\r\n3/9/2000\t12.97\t13\t12.91\t12.97\r\n3/8/2000\t12.91\t13.06\t12.84\t12.97\r\n3/7/2000\t12.81\t12.94\t12.63\t12.91\r\n3/6/2000\t13.03\t13.06\t12.84\t12.88\r\n3/3/2000\t12.94\t13.31\t12.81\t13.09\r\n3/2/2000\t12.56\t12.81\t12.5\t12.75\r\n3/1/2000\t12.59\t12.72\t12.47\t12.59\r\n2/29/2000\t12.38\t12.59\t12.38\t12.59\r\n2/28/2000\t12.06\t12.28\t12.06\t12.28\r\n2/25/2000\t12.06\t12.19\t12\t12.06\r\n2/24/2000\t12.31\t12.31\t11.81\t12\r\n2/23/2000\t12.06\t12.41\t12\t12.38\r\n2/22/2000\t12.31\t12.31\t11.81\t12.09\r\n2/18/2000\t12.56\t12.59\t12.31\t12.31\r\n2/17/2000\t11.88\t12.63\t11.81\t12.63\r\n2/16/2000\t11.5\t11.81\t11.44\t11.63\r\n2/15/2000\t11\t11.47\t11\t11.22\r\n2/14/2000\t10.88\t11.03\t10.88\t11.03\r\n2/11/2000\t10.84\t10.91\t10.66\t10.7\r\n2/10/2000\t10.53\t10.78\t10.53\t10.78\r\n2/9/2000\t10.59\t10.63\t10.5\t10.56\r\n2/8/2000\t10.75\t10.78\t10.53\t10.59\r\n2/7/2000\t10.88\t10.94\t10.75\t10.88\r\n2/4/2000\t10.5\t11\t10.44\t10.94\r\n2/3/2000\t10.25\t10.5\t10.25\t10.5\r\n2/2/2000\t10.34\t10.34\t10.19\t10.22\r\n2/1/2000\t10.31\t10.41\t10.13\t10.31\r\n1/31/2000\t10.22\t10.34\t10.19\t10.25\r\n1/28/2000\t10.25\t10.28\t10.09\t10.09\r\n1/27/2000\t10.22\t10.34\t10.22\t10.25\r\n1/26/2000\t10.28\t10.44\t10.22\t10.25\r\n1/25/2000\t10.53\t10.53\t10.28\t10.28\r\n1/24/2000\t10.56\t10.69\t10.53\t10.56\r\n1/21/2000\t10.16\t10.63\t10.13\t10.59\r\n1/20/2000\t10.13\t10.16\t9.91\t10.16\r\n1/19/2000\t9.97\t10.09\t9.94\t10.06\r\n1/18/2000\t10.06\t10.09\t9.84\t9.91\r\n1/14/2000\t10\t10.13\t9.94\t10.13\r\n1/13/2000\t9.97\t10.06\t9.63\t9.69\r\n1/12/2000\t9.97\t10.06\t9.94\t10\r\n1/11/2000\t10.13\t10.13\t10\t10.03\r\n1/10/2000\t10.13\t10.13\t10\t10.13\r\n1/7/2000\t10.09\t10.19\t10.03\t10.13\r\n1/6/2000\t10.09\t10.19\t10.03\t10.09\r\n1/5/2000\t10.13\t10.13\t10\t10.06\r\n1/4/2000\t10.06\t10.19\t10\t10.19\r\n1/3/2000\t10.25\t10.31\t10\t10.16\r\n";

        public FinancialViewModel()
        {
            string[] rows = CandleSource.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            ObservableCollection<ChartDataModel> collection = new ObservableCollection<ChartDataModel>();

            foreach (string row in rows)
            {
                string[] columns = row.Split('\t');
                // Create a new DataItem object and populate its properties using the columns
                ChartDataModel item = new ChartDataModel(GetDateTime(columns[0]), GetDouble(columns[2]), GetDouble(columns[3]), GetDouble(columns[1]), GetDouble(columns[4]));
                // Add the item to the collection
                collection.Add(item);
            }

            StockData = collection;

            rows = OHLCSource.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            ObservableCollection<ChartDataModel> collection_ohlc = new ObservableCollection<ChartDataModel>();

            foreach (string row in rows)
            {
                string[] columns = row.Split('\t');
                // Create a new DataItem object and populate its properties using the columns
                ChartDataModel item = new ChartDataModel(GetDateTime(columns[0]), GetDouble(columns[2]), GetDouble(columns[3]), GetDouble(columns[1]), GetDouble(columns[4]));
                // Add the item to the collection
                collection_ohlc.Add(item);
            }

            StockDataOHLC = collection_ohlc;
        }

        double GetDouble(string text)
        {
            double i = 0;

            if(double.TryParse(text,out i))
            {
                return i;
            }

            return i;
        }

        DateTime GetDateTime(string text)
        {
            var i = DateTime.Now;

            if (DateTime.TryParse(text, CultureInfo.InvariantCulture, DateTimeStyles.None, out i))
            {
                return i;
            }

            return i;
        }

    }
}
