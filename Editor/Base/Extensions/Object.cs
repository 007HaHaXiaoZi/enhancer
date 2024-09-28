using UObject = UnityEngine.Object;

namespace HaKid.Base {

internal static partial class Extensions {

public static void DestroyImmediate(this UObject obj) {
	if (obj != null) {
		UObject.DestroyImmediate(obj);
	}
}

}

}
