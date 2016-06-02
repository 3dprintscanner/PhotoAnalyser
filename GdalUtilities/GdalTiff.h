#pragma once


#ifdef YourLib_EXPORTS
#define API_DECL __declspec( dllexport )
#else 
#define API_DECL __declspec( dllimport )
#endif

namespace GdalUtilities{
	class GdalTiff
	{
	public:
		GdalTiff();
		~GdalTiff();
			

	};
}



