/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public enum aiPostProcessSteps {
  aiProcess_CalcTangentSpace = 0x1,
  aiProcess_JoinIdenticalVertices = 0x2,
  aiProcess_MakeLeftHanded = 0x4,
  aiProcess_Triangulate = 0x8,
  aiProcess_RemoveComponent = 0x10,
  aiProcess_GenNormals = 0x20,
  aiProcess_GenSmoothNormals = 0x40,
  aiProcess_SplitLargeMeshes = 0x80,
  aiProcess_PreTransformVertices = 0x100,
  aiProcess_LimitBoneWeights = 0x200,
  aiProcess_ValidateDataStructure = 0x400,
  aiProcess_ImproveCacheLocality = 0x800,
  aiProcess_RemoveRedundantMaterials = 0x1000,
  aiProcess_FixInfacingNormals = 0x2000,
  aiProcess_SortByPType = 0x8000,
  aiProcess_FindDegenerates = 0x10000,
  aiProcess_FindInvalidData = 0x20000,
  aiProcess_GenUVCoords = 0x40000,
  aiProcess_TransformUVCoords = 0x80000,
  aiProcess_FindInstances = 0x100000,
  aiProcess_OptimizeMeshes = 0x200000,
  aiProcess_OptimizeGraph = 0x400000,
  aiProcess_FlipUVs = 0x800000,
  aiProcess_FlipWindingOrder = 0x1000000

	, aiProcess_ConvertToLeftHanded = aiProcess_MakeLeftHanded|aiProcess_FlipUVs|aiProcess_FlipWindingOrder,
}