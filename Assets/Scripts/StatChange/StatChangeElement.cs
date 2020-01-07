using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface StatChangeElement {

	string Name { get; }

	bool Used { get; }

	void UseElement ();

	void ElementNotUsed ();
}
