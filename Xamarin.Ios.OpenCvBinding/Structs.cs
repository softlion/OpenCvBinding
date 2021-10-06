﻿using System;
using System.Runtime.InteropServices;
using Foundation;

namespace Xamarin.Ios.OpenCvBinding
{
    	static class CFunctions
	{
		// extern NSMutableArray * createArrayWithSize (int size, NSObject *val);
		[DllImport("__Internal")]
		//[Verify(PlatformInvoke)]
		static extern NSMutableArray createArrayWithSize(int size, NSObject val);
	}

	public enum BorderTypes
	{
		Constant = 0,
		Replicate = 1,
		Reflect = 2,
		Wrap = 3,
		Reflect101 = 4,
		Transparent = 5,
		Default = Reflect101,
		Isolated = 16
	}

	public enum CmpTypes
	{
		Eq = 0,
		Gt = 1,
		Ge = 2,
		Lt = 3,
		Le = 4,
		Ne = 5
	}

	public enum CovarFlags
	{
		Scrambled = 0,
		Normal = 1,
		UseAvg = 2,
		Scale = 4,
		Rows = 8,
		Cols = 16
	}

	public enum DecompTypes
	{
		Lu = 0,
		Svd = 1,
		Eig = 2,
		Cholesky = 3,
		Qr = 4,
		Normal = 16
	}

	public enum DftFlags
	{
		FtInverse = 1,
		FtScale = 2,
		FtRows = 4,
		FtComplexOutput = 16,
		FtRealOutput = 32,
		FtComplexInput = 64,
		CtInverse = FtInverse,
		CtRows = FtRows
	}

	public enum Code
	{
		StsOk = 0,
		StsBackTrace = -1,
		StsError = -2,
		StsInternal = -3,
		StsNoMem = -4,
		StsBadArg = -5,
		StsBadFunc = -6,
		StsNoConv = -7,
		StsAutoTrace = -8,
		HeaderIsNull = -9,
		BadImageSize = -10,
		BadOffset = -11,
		BadDataPtr = -12,
		BadStep = -13,
		BadModelOrChSeq = -14,
		BadNumChannels = -15,
		BadNumChannel1U = -16,
		BadDepth = -17,
		BadAlphaChannel = -18,
		BadOrder = -19,
		BadOrigin = -20,
		BadAlign = -21,
		BadCallBack = -22,
		BadTileSize = -23,
		BadCOI = -24,
		BadROISize = -25,
		MaskIsTiled = -26,
		StsNullPtr = -27,
		StsVecLengthErr = -28,
		StsFilterStructContentErr = -29,
		StsKernelStructContentErr = -30,
		StsFilterOffsetErr = -31,
		StsBadSize = -201,
		StsDivByZero = -202,
		StsInplaceNotSupported = -203,
		StsObjectNotFound = -204,
		StsUnmatchedFormats = -205,
		StsBadFlag = -206,
		StsBadPoint = -207,
		StsBadMask = -208,
		StsUnmatchedSizes = -209,
		StsUnsupportedFormat = -210,
		StsOutOfRange = -211,
		StsParseError = -212,
		StsNotImplemented = -213,
		StsBadMemBlock = -214,
		StsAssert = -215,
		GpuNotSupported = -216,
		GpuApiCallError = -217,
		OpenGlNotSupported = -218,
		OpenGlApiCallError = -219,
		OpenCLApiCallError = -220,
		OpenCLDoubleNotSupported = -221,
		OpenCLInitError = -222,
		OpenCLNoAMDBlasFft = -223
	}

	public enum FormatType
	{
		Default = 0,
		Matlab = 1,
		Csv = 2,
		Python = 3,
		Numpy = 4,
		C = 5
	}

	public enum GemmFlags
	{
		Gemm1T = 1,
		Gemm2T = 2,
		Gemm3T = 4
	}

	public enum KmeansFlags
	{
		RandomCenters = 0,
		PpCenters = 2,
		UseInitialLabels = 1
	}

	public enum NormTypes
	{
		Inf = 1,
		L1 = 2,
		L2 = 4,
		L2sqr = 5,
		Hamming = 6,
		Hamming2 = 7,
		TypeMask = 7,
		Relative = 8,
		Minmax = 32
	}

	public enum Flags
	{
		DataAsRow = 0,
		DataAsCol = 1,
		UseAvg = 2
	}

	public enum Param
	{
		Int = 0,
		Boolean = 1,
		Real = 2,
		String = 3,
		Mat = 4,
		MatVector = 5,
		Algorithm = 6,
		Float = 7,
		UnsignedInt = 8,
		Uint64 = 9,
		Uchar = 11,
		Scalar = 12
	}

	public enum RotateFlags
	{
		Rotate90Clockwise = 0,
		Rotate180 = 1,
		Rotate90Counterclockwise = 2
	}

	public enum SortFlags
	{
		EveryRow = 0,
		EveryColumn = 1,
		Ascending = 0,
		Descending = 16
	}

	public enum AdaptiveThresholdTypes
	{
		MeanC = 0,
		GaussianC = 1
	}

	public enum ColorConversionCodes
	{
		Bgr2bgra = 0,
		Rgb2rgba = Bgr2bgra,
		Bgra2bgr = 1,
		Rgba2rgb = Bgra2bgr,
		Bgr2rgba = 2,
		Rgb2bgra = Bgr2rgba,
		Rgba2bgr = 3,
		Bgra2rgb = Rgba2bgr,
		Bgr2rgb = 4,
		Rgb2bgr = Bgr2rgb,
		Bgra2rgba = 5,
		Rgba2bgra = Bgra2rgba,
		Bgr2gray = 6,
		Rgb2gray = 7,
		Gray2bgr = 8,
		Gray2rgb = Gray2bgr,
		Gray2bgra = 9,
		Gray2rgba = Gray2bgra,
		Bgra2gray = 10,
		Rgba2gray = 11,
		Bgr2bgr565 = 12,
		Rgb2bgr565 = 13,
		Bgr5652bgr = 14,
		Bgr5652rgb = 15,
		Bgra2bgr565 = 16,
		Rgba2bgr565 = 17,
		Bgr5652bgra = 18,
		Bgr5652rgba = 19,
		Gray2bgr565 = 20,
		Bgr5652gray = 21,
		Bgr2bgr555 = 22,
		Rgb2bgr555 = 23,
		Bgr5552bgr = 24,
		Bgr5552rgb = 25,
		Bgra2bgr555 = 26,
		Rgba2bgr555 = 27,
		Bgr5552bgra = 28,
		Bgr5552rgba = 29,
		Gray2bgr555 = 30,
		Bgr5552gray = 31,
		Bgr2xyz = 32,
		Rgb2xyz = 33,
		Xyz2bgr = 34,
		Xyz2rgb = 35,
		BGR2YCrCb = 36,
		RGB2YCrCb = 37,
		YCrCb2BGR = 38,
		YCrCb2RGB = 39,
		Bgr2hsv = 40,
		Rgb2hsv = 41,
		BGR2Lab = 44,
		RGB2Lab = 45,
		BGR2Luv = 50,
		RGB2Luv = 51,
		Bgr2hls = 52,
		Rgb2hls = 53,
		Hsv2bgr = 54,
		Hsv2rgb = 55,
		Lab2BGR = 56,
		Lab2RGB = 57,
		Luv2BGR = 58,
		Luv2RGB = 59,
		Hls2bgr = 60,
		Hls2rgb = 61,
		Bgr2hsvFull = 66,
		Rgb2hsvFull = 67,
		Bgr2hlsFull = 68,
		Rgb2hlsFull = 69,
		Hsv2bgrFull = 70,
		Hsv2rgbFull = 71,
		Hls2bgrFull = 72,
		Hls2rgbFull = 73,
		LBGR2Lab = 74,
		LRGB2Lab = 75,
		LBGR2Luv = 76,
		LRGB2Luv = 77,
		Lab2LBGR = 78,
		Lab2LRGB = 79,
		Luv2LBGR = 80,
		Luv2LRGB = 81,
		Bgr2yuv = 82,
		Rgb2yuv = 83,
		Yuv2bgr = 84,
		Yuv2rgb = 85,
		Yuv2rgbNv12 = 90,
		Yuv2bgrNv12 = 91,
		Yuv2rgbNv21 = 92,
		Yuv2bgrNv21 = 93,
		YUV420sp2RGB = Yuv2rgbNv21,
		YUV420sp2BGR = Yuv2bgrNv21,
		Yuv2rgbaNv12 = 94,
		Yuv2bgraNv12 = 95,
		Yuv2rgbaNv21 = 96,
		Yuv2bgraNv21 = 97,
		YUV420sp2RGBA = Yuv2rgbaNv21,
		YUV420sp2BGRA = Yuv2bgraNv21,
		Yuv2rgbYv12 = 98,
		Yuv2bgrYv12 = 99,
		Yuv2rgbIyuv = 100,
		Yuv2bgrIyuv = 101,
		Yuv2rgbI420 = Yuv2rgbIyuv,
		Yuv2bgrI420 = Yuv2bgrIyuv,
		YUV420p2RGB = Yuv2rgbYv12,
		YUV420p2BGR = Yuv2bgrYv12,
		Yuv2rgbaYv12 = 102,
		Yuv2bgraYv12 = 103,
		Yuv2rgbaIyuv = 104,
		Yuv2bgraIyuv = 105,
		Yuv2rgbaI420 = Yuv2rgbaIyuv,
		Yuv2bgraI420 = Yuv2bgraIyuv,
		YUV420p2RGBA = Yuv2rgbaYv12,
		YUV420p2BGRA = Yuv2bgraYv12,
		Yuv2gray420 = 106,
		Yuv2grayNv21 = Yuv2gray420,
		Yuv2grayNv12 = Yuv2gray420,
		Yuv2grayYv12 = Yuv2gray420,
		Yuv2grayIyuv = Yuv2gray420,
		Yuv2grayI420 = Yuv2gray420,
		YUV420sp2GRAY = Yuv2gray420,
		YUV420p2GRAY = Yuv2gray420,
		Yuv2rgbUyvy = 107,
		Yuv2bgrUyvy = 108,
		Yuv2rgbY422 = Yuv2rgbUyvy,
		Yuv2bgrY422 = Yuv2bgrUyvy,
		Yuv2rgbUynv = Yuv2rgbUyvy,
		Yuv2bgrUynv = Yuv2bgrUyvy,
		Yuv2rgbaUyvy = 111,
		Yuv2bgraUyvy = 112,
		Yuv2rgbaY422 = Yuv2rgbaUyvy,
		Yuv2bgraY422 = Yuv2bgraUyvy,
		Yuv2rgbaUynv = Yuv2rgbaUyvy,
		Yuv2bgraUynv = Yuv2bgraUyvy,
		Yuv2rgbYuy2 = 115,
		Yuv2bgrYuy2 = 116,
		Yuv2rgbYvyu = 117,
		Yuv2bgrYvyu = 118,
		Yuv2rgbYuyv = Yuv2rgbYuy2,
		Yuv2bgrYuyv = Yuv2bgrYuy2,
		Yuv2rgbYunv = Yuv2rgbYuy2,
		Yuv2bgrYunv = Yuv2bgrYuy2,
		Yuv2rgbaYuy2 = 119,
		Yuv2bgraYuy2 = 120,
		Yuv2rgbaYvyu = 121,
		Yuv2bgraYvyu = 122,
		Yuv2rgbaYuyv = Yuv2rgbaYuy2,
		Yuv2bgraYuyv = Yuv2bgraYuy2,
		Yuv2rgbaYunv = Yuv2rgbaYuy2,
		Yuv2bgraYunv = Yuv2bgraYuy2,
		Yuv2grayUyvy = 123,
		Yuv2grayYuy2 = 124,
		Yuv2grayY422 = Yuv2grayUyvy,
		Yuv2grayUynv = Yuv2grayUyvy,
		Yuv2grayYvyu = Yuv2grayYuy2,
		Yuv2grayYuyv = Yuv2grayYuy2,
		Yuv2grayYunv = Yuv2grayYuy2,
		RGBA2mRGBA = 125,
		mRGBA2RGBA = 126,
		Rgb2yuvI420 = 127,
		Bgr2yuvI420 = 128,
		Rgb2yuvIyuv = Rgb2yuvI420,
		Bgr2yuvIyuv = Bgr2yuvI420,
		Rgba2yuvI420 = 129,
		Bgra2yuvI420 = 130,
		Rgba2yuvIyuv = Rgba2yuvI420,
		Bgra2yuvIyuv = Bgra2yuvI420,
		Rgb2yuvYv12 = 131,
		Bgr2yuvYv12 = 132,
		Rgba2yuvYv12 = 133,
		Bgra2yuvYv12 = 134,
		BayerBG2BGR = 46,
		BayerGB2BGR = 47,
		BayerRG2BGR = 48,
		BayerGR2BGR = 49,
		BayerBG2RGB = BayerRG2BGR,
		BayerGB2RGB = BayerGR2BGR,
		BayerRG2RGB = BayerBG2BGR,
		BayerGR2RGB = BayerGB2BGR,
		BayerBG2GRAY = 86,
		BayerGB2GRAY = 87,
		BayerRG2GRAY = 88,
		BayerGR2GRAY = 89,
		BayerBG2BGR_VNG = 62,
		BayerGB2BGR_VNG = 63,
		BayerRG2BGR_VNG = 64,
		BayerGR2BGR_VNG = 65,
		BayerBG2RGB_VNG = BayerRG2BGR_VNG,
		BayerGB2RGB_VNG = BayerGR2BGR_VNG,
		BayerRG2RGB_VNG = BayerBG2BGR_VNG,
		BayerGR2RGB_VNG = BayerGB2BGR_VNG,
		BayerBG2BGR_EA = 135,
		BayerGB2BGR_EA = 136,
		BayerRG2BGR_EA = 137,
		BayerGR2BGR_EA = 138,
		BayerBG2RGB_EA = BayerRG2BGR_EA,
		BayerGB2RGB_EA = BayerGR2BGR_EA,
		BayerRG2RGB_EA = BayerBG2BGR_EA,
		BayerGR2RGB_EA = BayerGB2BGR_EA,
		BayerBG2BGRA = 139,
		BayerGB2BGRA = 140,
		BayerRG2BGRA = 141,
		BayerGR2BGRA = 142,
		BayerBG2RGBA = BayerRG2BGRA,
		BayerGB2RGBA = BayerGR2BGRA,
		BayerRG2RGBA = BayerBG2BGRA,
		BayerGR2RGBA = BayerGB2BGRA,
		ColorcvtMax = 143
	}

	public enum ColormapTypes
	{
		Autumn = 0,
		Bone = 1,
		Jet = 2,
		Winter = 3,
		Rainbow = 4,
		Ocean = 5,
		Summer = 6,
		Spring = 7,
		Cool = 8,
		Hsv = 9,
		Pink = 10,
		Hot = 11,
		Parula = 12,
		Magma = 13,
		Inferno = 14,
		Plasma = 15,
		Viridis = 16,
		Cividis = 17,
		Twilight = 18,
		TwilightShifted = 19,
		Turbo = 20,
		Deepgreen = 21
	}

	public enum ConnectedComponentsAlgorithmsTypes
	{
		Default = -1,
		Wu = 0,
		Grana = 1,
		Bolelli = 2,
		Sauf = 3,
		Bbdt = 4,
		Spaghetti = 5
	}

	public enum ConnectedComponentsTypes
	{
		Left = 0,
		Top = 1,
		Width = 2,
		Height = 3,
		Area = 4,
		Max = 5
	}

	public enum ContourApproximationModes
	{
		None = 1,
		Simple = 2,
		Tc89L1 = 3,
		Tc89Kcos = 4
	}

	public enum DistanceTransformLabelTypes
	{
		Ccomp = 0,
		Pixel = 1
	}

	public enum DistanceTransformMasks
	{
		DistMask3 = 3,
		DistMask5 = 5,
		Precise = 0
	}

	public enum DistanceTypes
	{
		User = -1,
		L1 = 1,
		L2 = 2,
		C = 3,
		L12 = 4,
		Fair = 5,
		Welsch = 6,
		Huber = 7
	}

	public enum FloodFillFlags
	{
		FixedRange = 1 << 16,
		MaskOnly = 1 << 17
	}

	public enum GrabCutClasses
	{
		Bgd = 0,
		Fgd = 1,
		PrBgd = 2,
		PrFgd = 3
	}

	public enum GrabCutModes
	{
		InitWithRect = 0,
		InitWithMask = 1,
		Eval = 2,
		EvalFreezeModel = 3
	}

	public enum HersheyFonts
	{
		HersheySimplex = 0,
		HersheyPlain = 1,
		HersheyDuplex = 2,
		HersheyComplex = 3,
		HersheyTriplex = 4,
		HersheyComplexSmall = 5,
		HersheyScriptSimplex = 6,
		HersheyScriptComplex = 7,
		Italic = 16
	}

	public enum HistCompMethods
	{
		Correl = 0,
		Chisqr = 1,
		Intersect = 2,
		Bhattacharyya = 3,
		Hellinger = Bhattacharyya,
		ChisqrAlt = 4,
		KlDiv = 5
	}

	public enum HoughModes
	{
		Standard = 0,
		Probabilistic = 1,
		MultiScale = 2,
		Gradient = 3,
		GradientAlt = 4
	}

	public enum InterpolationFlags
	{
		InterNearest = 0,
		InterLinear = 1,
		InterCubic = 2,
		InterArea = 3,
		InterLanczos4 = 4,
		InterLinearExact = 5,
		InterNearestExact = 6,
		InterMax = 7,
		WarpFillOutliers = 8,
		WarpInverseMap = 16
	}

	public enum InterpolationMasks
	{
		Bits = 5,
		Bits2 = Bits * 2,
		TabSize = 1 << Bits,
		TabSize2 = TabSize * TabSize
	}

	public enum LineSegmentDetectorModes
	{
		None = 0,
		Std = 1,
		Adv = 2
	}

	public enum LineTypes
	{
		Filled = -1,
		Line4 = 4,
		Line8 = 8,
		LineAa = 16
	}

	public enum MarkerTypes
	{
		Cross = 0,
		TiltedCross = 1,
		Star = 2,
		Diamond = 3,
		Square = 4,
		TriangleUp = 5,
		TriangleDown = 6
	}

	public enum MorphShapes
	{
		Rect = 0,
		Cross = 1,
		Ellipse = 2
	}

	public enum MorphTypes
	{
		Erode = 0,
		Dilate = 1,
		Open = 2,
		Close = 3,
		Gradient = 4,
		Tophat = 5,
		Blackhat = 6,
		Hitmiss = 7
	}

	public enum RectanglesIntersectTypes
	{
		None = 0,
		Partial = 1,
		Full = 2
	}

	public enum RetrievalModes
	{
		External = 0,
		List = 1,
		Ccomp = 2,
		Tree = 3,
		Floodfill = 4
	}

	public enum ShapeMatchModes
	{
		ContoursMatchI1 = 1,
		ContoursMatchI2 = 2,
		ContoursMatchI3 = 3
	}

	public enum SpecialFilter
	{
		FilterScharr = -1
	}

	public enum TemplateMatchModes
	{
		Sqdiff = 0,
		SqdiffNormed = 1,
		Ccorr = 2,
		CcorrNormed = 3,
		Ccoeff = 4,
		CcoeffNormed = 5
	}

	public enum ThresholdTypes
	{
		Binary = 0,
		BinaryInv = 1,
		Trunc = 2,
		Tozero = 3,
		TozeroInv = 4,
		Mask = 7,
		Otsu = 8,
		Triangle = 16
	}

	public enum WarpPolarMode
	{
		Inear = 0,
		Og = 256
	}

	public enum ErrorTypes
	{
		EstError = 0,
		RainError = 1
	}

	public enum SampleTypes
	{
		RowSample = 0,
		ColSample = 1
	}

	public enum VariableTypes
	{
		Numerical = 0,
		Ordered = 0,
		Categorical = 1
	}

	public enum StatModelFlags
	{
		UpdateModel = 1,
		RawOutput = 1,
		CompressedInput = 2,
		PreprocessedInput = 4
	}

	public enum ActivationFunctions
	{
		Identity = 0,
		SigmoidSym = 1,
		Gaussian = 2,
		Relu = 3,
		Leakyrelu = 4
	}

	public enum TrainFlags
	{
		UpdateWeights = 1,
		NoInputScale = 2,
		NoOutputScale = 4
	}

	public enum TrainingMethods
	{
		Backprop = 0,
		Rprop = 1,
		Anneal = 2
	}

	public enum DTreeFlags
	{
		Auto = 0,
		Sum = (1 << 8),
		MaxVote = (2 << 8),
		Mask = (3 << 8)
	}

	public enum Types
	{
		Discrete = 0,
		Real = 1,
		Logit = 2,
		Gentle = 3
	}

	public enum EMTypes
	{
		Spherical = 0,
		Diagonal = 1,
		Generic = 2,
		Default = Diagonal
	}

	public enum KNearestTypes
	{
		BruteForce = 1,
		Kdtree = 2
	}

	public enum Methods
	{
		Batch = 0,
		MiniBatch = 1
	}

	public enum RegKinds
	{
		Disable = -1,
		L1 = 0,
		L2 = 1
	}

	public enum KernelTypes
	{
		Custom = -1,
		Linear = 0,
		Poly = 1,
		Rbf = 2,
		Sigmoid = 3,
		Chi2 = 4,
		Inter = 5
	}

	public enum ParamTypes
	{
		C = 0,
		Gamma = 1,
		P = 2,
		Nu = 3,
		Coef = 4,
		Degree = 5
	}

	public enum SVMTypes
	{
		CSvc = 100,
		NuSvc = 101,
		OneClass = 102,
		EpsSvr = 103,
		NuSvr = 104
	}

	public enum MarginType
	{
		SoftMargin = 0,
		HardMargin = 1
	}

	public enum SvmsgdType
	{
		Sgd = 0,
		Asgd = 1
	}

	public enum Backend
	{
		Default = 0,
		Halide = 0 + 1,
		InferenceEngine = 0 + 2,
		Opencv = 0 + 3,
		Vkcom = 0 + 4,
		Cuda = 0 + 5
	}

	public enum Target
	{
		Cpu = 0,
		Opencl = 0 + 1,
		OpenclFp16 = 0 + 2,
		Myriad = 0 + 3,
		Vulkan = 0 + 4,
		Fpga = 0 + 5,
		Cuda = 0 + 6,
		CudaFp16 = 0 + 7,
		Hddl = 0 + 8
	}

	public enum DrawMatchesFlags
	{
		Default = 0,
		DrawOverOutimg = 1,
		NotDrawSinglePoints = 2,
		DrawRichKeypoints = 4
	}

	public enum DiffusivityType
	{
		PmG1 = 0,
		PmG2 = 1,
		Weickert = 2,
		Charbonnier = 3
	}

	public enum DescriptorType
	{
		KazeUpright = 2,
		Kaze = 3,
		MldbUpright = 4,
		Mldb = 5
	}

	public enum AgastDetectorType
	{
		Agast58 = 0,
		AGAST_7_12d = 1,
		AGAST_7_12s = 2,
		Oast916 = 3
	}

	public enum MatcherType
	{
		Flannbased = 1,
		Bruteforce = 2,
		BruteforceL1 = 3,
		BruteforceHamming = 4,
		BruteforceHamminglut = 5,
		BruteforceSl2 = 6
	}

	public enum FastDetectorType
	{
		Type58 = 0,
		Type712 = 1,
		Type916 = 2
	}

	public enum ScoreType
	{
		HarrisScore = 0,
		FastScore = 1
	}

	public enum ImreadModes
	{
		Unchanged = -1,
		Grayscale = 0,
		Color = 1,
		Anydepth = 2,
		Anycolor = 4,
		LoadGdal = 8,
		ReducedGrayscale2 = 16,
		ReducedColor2 = 17,
		ReducedGrayscale4 = 32,
		ReducedColor4 = 33,
		ReducedGrayscale8 = 64,
		ReducedColor8 = 65,
		IgnoreOrientation = 128
	}

	public enum ImwriteEXRCompressionFlags
	{
		No = 0,
		Rle = 1,
		Zips = 2,
		Zip = 3,
		Piz = 4,
		Pxr24 = 5,
		B44 = 6,
		B44a = 7,
		Dwaa = 8,
		Dwab = 9
	}

	public enum ImwriteEXRTypeFlags
	{
		Half = 1,
		Float = 2
	}

	public enum ImwriteFlags
	{
		JpegQuality = 1,
		JpegProgressive = 2,
		JpegOptimize = 3,
		JpegRstInterval = 4,
		JpegLumaQuality = 5,
		JpegChromaQuality = 6,
		PngCompression = 16,
		PngStrategy = 17,
		PngBilevel = 18,
		PxmBinary = 32,
		ExrType = (3 << 4) + 0,
		ExrCompression = (3 << 4) + 1,
		WebpQuality = 64,
		PamTupletype = 128,
		TiffResunit = 256,
		TiffXdpi = 257,
		TiffYdpi = 258,
		TiffCompression = 259,
		Jpeg2000CompressionX1000 = 272
	}

	public enum ImwritePAMFlags
	{
		Null = 0,
		Blackandwhite = 1,
		Grayscale = 2,
		GrayscaleAlpha = 3,
		Rgb = 4,
		RgbAlpha = 5
	}

	public enum ImwritePNGFlags
	{
		Default = 0,
		Filtered = 1,
		HuffmanOnly = 2,
		Rle = 3,
		Fixed = 4
	}

	public enum VideoAccelerationType
	{
		None = 0,
		Any = 1,
		D3d11 = 2,
		Vaapi = 3,
		Mfx = 4
	}

	public enum VideoCaptureAPIs
	{
		Any = 0,
		Vfw = 200,
		V4l = 200,
		V4l2 = V4l,
		Firewire = 300,
		Fireware = Firewire,
		Ieee1394 = Firewire,
		Dc1394 = Firewire,
		Cmu1394 = Firewire,
		Qt = 500,
		Unicap = 600,
		Dshow = 700,
		Pvapi = 800,
		Openni = 900,
		OpenniAsus = 910,
		Android = 1000,
		Xiapi = 1100,
		Avfoundation = 1200,
		Giganetix = 1300,
		Msmf = 1400,
		Winrt = 1410,
		Intelperc = 1500,
		Realsense = 1500,
		Openni2 = 1600,
		Openni2Asus = 1610,
		Openni2Astra = 1620,
		Gphoto2 = 1700,
		Gstreamer = 1800,
		Ffmpeg = 1900,
		Images = 2000,
		Aravis = 2100,
		OpencvMjpeg = 2200,
		IntelMfx = 2300,
		Xine = 2400,
		Ueye = 2500
	}

	public enum VideoCaptureProperties
	{
		PosMsec = 0,
		PosFrames = 1,
		PosAviRatio = 2,
		FrameWidth = 3,
		FrameHeight = 4,
		Fps = 5,
		Fourcc = 6,
		FrameCount = 7,
		Format = 8,
		Mode = 9,
		Brightness = 10,
		Contrast = 11,
		Saturation = 12,
		Hue = 13,
		Gain = 14,
		Exposure = 15,
		ConvertRgb = 16,
		WhiteBalanceBlueU = 17,
		Rectification = 18,
		Monochrome = 19,
		Sharpness = 20,
		AutoExposure = 21,
		Gamma = 22,
		Temperature = 23,
		Trigger = 24,
		TriggerDelay = 25,
		WhiteBalanceRedV = 26,
		Zoom = 27,
		Focus = 28,
		Guid = 29,
		IsoSpeed = 30,
		Backlight = 32,
		Pan = 33,
		Tilt = 34,
		Roll = 35,
		Iris = 36,
		Settings = 37,
		Buffersize = 38,
		Autofocus = 39,
		SarNum = 40,
		SarDen = 41,
		Backend = 42,
		Channel = 43,
		AutoWb = 44,
		WbTemperature = 45,
		CodecPixelFormat = 46,
		Bitrate = 47,
		OrientationMeta = 48,
		OrientationAuto = 49,
		HwAcceleration = 50,
		HwDevice = 51,
		HwAccelerationUseOpencl = 52,
		OpenTimeoutMsec = 53,
		ReadTimeoutMsec = 54,
		StreamOpenTimeUsec = 55
	}

	public enum VideoWriterProperties
	{
		Quality = 1,
		Framebytes = 2,
		Nstripes = 3,
		IsColor = 4,
		Depth = 5,
		HwAcceleration = 6,
		HwDevice = 7,
		HwAccelerationUseOpencl = 8
	}

	public enum HandEyeCalibrationMethod
	{
		Tsai = 0,
		Park = 1,
		Horaud = 2,
		Andreff = 3,
		Daniilidis = 4
	}

	public enum LocalOptimMethod
	{
		Null = 0,
		InnerLo = 1,
		InnerAndIterLo = 2,
		Gc = 3,
		Sigma = 4
	}

	public enum NeighborSearchMethod
	{
		FlannKnn = 0,
		Grid = 1,
		FlannRadius = 2
	}

	public enum RobotWorldHandEyeCalibrationMethod
	{
		Shah = 0,
		Li = 1
	}

	public enum SamplingMethod
	{
		Uniform = 0,
		ProgressiveNapsac = 1,
		Napsac = 2,
		Prosac = 3
	}

	public enum ScoreMethod
	{
		Ransac = 0,
		Msac = 1,
		Magsac = 2,
		Lmeds = 3
	}

	public enum SolvePnPMethod
	{
		Iterative = 0,
		Epnp = 1,
		P3p = 2,
		Dls = 3,
		Upnp = 4,
		Ap3p = 5,
		Ippe = 6,
		IppeSquare = 7,
		Sqpnp = 8,
		MaxCount = 8 + 1
	}

	public enum UndistortTypes
	{
		Ortho = 0,
		Eqrect = 1
	}

	public enum GridType
	{
		SymmetricGrid = 0,
		AsymmetricGrid = 1
	}

	public enum ObjectStatus
	{
		DetectedNotShownYet = 0,
		Detected = 1,
		DetectedTemporaryLost = 2,
		WrongObject = 3
	}

	public enum DescriptorStorageFormat
	{
		ColByCol = 0,
		RowByRow = 1
	}

	public enum HistogramNormType
	{
		L2Hys = 0
	}
}

