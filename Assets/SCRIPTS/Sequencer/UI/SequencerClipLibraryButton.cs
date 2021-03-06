﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SequencerClipLibraryButton : MonoBehaviour {

	private SequencerClip m_sequencerClip;
	public SequencerClip sequencerClip {
		get { return m_sequencerClip; }
	}
	[SerializeField]
	private MusicSequencer musicSequencer;

	public void Initialize (SequencerClip clip) {
		m_sequencerClip = clip;
		text.text = clip.name + " (" + clip.length + ")";
		button.image.sprite = clip.bannerSprite;
	}

	[SerializeField]
	private Text text;

	[SerializeField]
	private Button button;

	public void OnClick () {
		musicSequencer.currentClipSelected = sequencerClip;
	}

	[SerializeField]
	private SineBobUI sineBobUI;
	[SerializeField]
	private GameObject highlightObject;
	public bool highlighted {
		get {
			return highlightObject.activeSelf;
		}
		set {
			highlightObject.SetActive (value);
			sineBobUI.enabled = value;
		}
	}
}
