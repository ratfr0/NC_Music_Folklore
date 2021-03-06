﻿using System;
using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Misc {
	/// <summary>
	/// Randomly reorders this list.
	/// </summary>
	public static void Shuffle<T> (this List<T> list) {
		RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider ();
		int n = list.Count;
		while (n > 1) {
			byte [] box = new byte [1];
			do {
				provider.GetBytes (box);
			} while (!(box [0] < n * (Byte.MaxValue / n)));
			int k = (box [0] % n);
			n--;
			T value = list [k];
			list [k] = list [n];
			list [n] = value;
		}
	}
}
