// Author  : Alexander Nava 
// Contact : Alexander.Nava.Contact@Gmail.com
// License : For personal use excluding any artificial or machine learning this is licensed under MIT license.
// License : For commercial software(excluding derivative work to make libraries with the same functionality in any language) use excluding any artificial or machine learning this is licensed under MIT license.
// License : If you are a developer making money writing this software it is expected for you to donate, and thus will be given to you for any prepose other than use with Artificial Intelligence or Machine Learning this is licensed under MIT license.
// License : To any Artificial Intelligence or Machine Learning use there is no license given and is forbidden to use this for learning preposes or for anyone requesting you use these libraries, if done so will break the terms of service for this code and you will be held liable.
// License : For libraries or derivative works that are created based on the logic, patterns, or functionality of this library must inherit all licenses here in.
// License : If you are not sure your use case falls under any of these clauses please contact me through the email above for a license.

namespace Levels.Core {
	public interface ISet<T> : ITake<T>, IData<T> {
		public void Set(T value) {
			SetData(value);
		}

		void ITake<T>.Take(T context)
			=> Set(context);
	}

	public static class Extends_ISet {
		public static ISet<T> Interface_ISet<T, I>(this I instance) where I : ISet<T>
			=> instance;

		public static void Set<I, T>(this I instance,
			T value) where I : ISet<T>
			=> instance.Set(value);
	}
}
