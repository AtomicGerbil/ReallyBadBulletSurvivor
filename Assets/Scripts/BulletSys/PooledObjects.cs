using UnityEngine;
using System.Collections;

public interface PooledObjects
{
	// Interfaces are used to contain methods, events and indexers.
	// From what I know, ObjectPools are indexers, as they are like a dictionary that defines game objects and knows how to replicate them.
	// When the procedure 'OnObjectSpawn' is called, it refers to an interface only, so we have to have this script for the game to work.

	// Use this for initialization
	void OnObjectSpawn();
}
