﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xbim.Common.Geometry;
using Xbim.Ifc;
using Xbim.Ifc4.Interfaces;
using Xbim.Tessellator;

namespace Xbim.IO.Tests
{
    [TestClass]
    public class TessellatorTests
    {
        [TestMethod]
        public void Test_Large_Coordinates_Reduction()
        {
            XbimGeometryType tp = Xbim.Common.Geometry.XbimGeometryType.PolyhedronBinary;
            using (var model = IfcStore.Open("TestFiles\\LargeTriangulatedCoordinates.ifc"))
            {
                var xbimTessellator = new XbimTessellator(model, tp);
                var shape = model.Instances.FirstOrDefault<IIfcFacetedBrep>();
                var shapeGeom = xbimTessellator.Mesh(shape);

                Assert.IsTrue(shapeGeom.LocalShapeDisplacement.HasValue);
            }
        }

        [TestMethod]
        public void Test_PolygonalFaceSet_Tessellation()
        {
            XbimGeometryType tp = Xbim.Common.Geometry.XbimGeometryType.PolyhedronBinary;
            using (var model = IfcStore.Open("TestFiles\\polygonal-face-tessellation.ifc"))
            {
                var xbimTessellator = new XbimTessellator(model, tp);
                XbimShapeGeometry shapeGeom = null;

                var shape = model.Instances.FirstOrDefault<IIfcPolygonalFaceSet>();
                shapeGeom = xbimTessellator.Mesh(shape);
                Assert.AreEqual(8000000000000, shapeGeom.BoundingBox.Volume);
            }
        }

        [TestMethod]
        public void TestBoundingBoxSize()
        {
            XbimGeometryType tp = Xbim.Common.Geometry.XbimGeometryType.PolyhedronBinary;
            using (var model = IfcStore.Open("TestFiles\\Roof-01_BCAD.ifc"))
            {
                var xbimTessellator = new XbimTessellator(model, tp);
                XbimShapeGeometry shapeGeom = null;
                
                var shape = model.Instances[1192] as IIfcGeometricRepresentationItem;
                shapeGeom = xbimTessellator.Mesh(shape);
                Debug.WriteLine(shapeGeom.BoundingBox);
            }
        }

        [TestMethod]
        public void TestPnSize_Add2_Support()
        {
            XbimGeometryType tp = Xbim.Common.Geometry.XbimGeometryType.PolyhedronBinary;
            using (var model = IfcStore.Open("TestFiles\\IfcTriangulatedFaceSet.ifc"))
            {
                var xbimTessellator = new XbimTessellator(model, tp);
                XbimShapeGeometry shapeGeom = null;

                var shape = model.Instances[48] as IIfcGeometricRepresentationItem;
                shapeGeom = xbimTessellator.Mesh(shape);
                Debug.WriteLine(shapeGeom.BoundingBox);
            }
        }
    }
}
