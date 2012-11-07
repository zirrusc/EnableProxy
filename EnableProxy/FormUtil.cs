using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace EnableProxy
{
	/// <summary>
	/// フォームを操作するためのクラスです
	/// すべてのフォームに共通です
	/// </summary>
	class FormUtil
	{
		/// <summary>
		/// アニメーション付きでフォームサイズを変更するときに使います
		/// このメソッドは、新しいフォームサイズを返すだけなので、whileでループさせて使う必要があります
		/// </summary>
		/// <param name="CurrentSize">現在のサイズを指定します</param>
		/// <param name="NewSize">新しいサイズを指定します。通常、固定値を指定します</param>
		/// <param name="AnimationSpeed">スピードを指定します</param>
		/// <returns></returns>
		public static Size ChangeFormSizeWithAnimation(Size CurrentSize, Size NewSize, int AnimationSpeed)
		{
			int width, height;
			// width
			width = ChangeOneDimension(CurrentSize.Width, NewSize.Width, AnimationSpeed);
			// height
			height = ChangeOneDimension(CurrentSize.Height, NewSize.Height, AnimationSpeed);
			return new Size(width, height);
		}

		private static int ChangeOneDimension(int CurrentValue, int NewValue, int ChangeSpeed)
		{
			int returnValue;
			int diff = NewValue - CurrentValue;
			if (Math.Abs(diff) < ChangeSpeed)
			{
				return NewValue;
			}
			// 新しい値のほうが大きい　→　大きくする
			if (diff > 0)
			{
				returnValue = CurrentValue + ChangeSpeed;
			}
			else // 現在の値のほうが大きい　→　小さくする
			{
				returnValue = CurrentValue - ChangeSpeed;
			}
			return returnValue;
		}


	}
}
