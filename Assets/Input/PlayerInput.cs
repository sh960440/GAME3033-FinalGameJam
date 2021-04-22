// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""93a4c207-094e-4599-9e2c-2c3d0abad7bd"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""b7f743fe-3b0a-46d2-a4f9-4aad6164f68b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StartMoving"",
                    ""type"": ""Button"",
                    ""id"": ""1e72013c-1ee0-4bee-a2e8-86e41127da80"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StopMoving"",
                    ""type"": ""Button"",
                    ""id"": ""2fbea751-3441-4d36-bbb0-68cb4437a842"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StartRotating"",
                    ""type"": ""Button"",
                    ""id"": ""d6dab1bb-e52f-498b-b3fe-09870d14e458"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StopRotating"",
                    ""type"": ""Button"",
                    ""id"": ""842e085f-95fa-4933-8ce2-f7513a44b5b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""cbf03395-7e9a-4320-9248-795fb2e3559e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StartJumping"",
                    ""type"": ""Button"",
                    ""id"": ""b0a82cc3-59eb-4cb3-9fc4-9996182460e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StopJumping"",
                    ""type"": ""Button"",
                    ""id"": ""774d14bb-62f4-4e14-b622-1d71564de526"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eaaf6358-5a32-40a4-b5f7-0dde7df43396"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2a8cbc3-590b-4778-8e9a-75487dd61be9"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2242862b-408b-483e-a957-85dee87144ab"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartMoving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21357b88-42cb-48a9-8216-e581b9174cf0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StopMoving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2cde9069-4ef7-4e89-b3bb-c12bbc886aff"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartRotating"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab10d729-8fb6-412d-9c84-f83c6edec07f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StopRotating"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef4219b9-f4ea-4037-a774-5682520bda9c"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""466926d1-6496-4333-ad5e-f2d64348fa06"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartJumping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83f4b733-9c5f-4f8a-ac38-fe010d351730"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StopJumping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
        m_Player_StartMoving = m_Player.FindAction("StartMoving", throwIfNotFound: true);
        m_Player_StopMoving = m_Player.FindAction("StopMoving", throwIfNotFound: true);
        m_Player_StartRotating = m_Player.FindAction("StartRotating", throwIfNotFound: true);
        m_Player_StopRotating = m_Player.FindAction("StopRotating", throwIfNotFound: true);
        m_Player_Rotate = m_Player.FindAction("Rotate", throwIfNotFound: true);
        m_Player_StartJumping = m_Player.FindAction("StartJumping", throwIfNotFound: true);
        m_Player_StopJumping = m_Player.FindAction("StopJumping", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Pause;
    private readonly InputAction m_Player_StartMoving;
    private readonly InputAction m_Player_StopMoving;
    private readonly InputAction m_Player_StartRotating;
    private readonly InputAction m_Player_StopRotating;
    private readonly InputAction m_Player_Rotate;
    private readonly InputAction m_Player_StartJumping;
    private readonly InputAction m_Player_StopJumping;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputAction @StartMoving => m_Wrapper.m_Player_StartMoving;
        public InputAction @StopMoving => m_Wrapper.m_Player_StopMoving;
        public InputAction @StartRotating => m_Wrapper.m_Player_StartRotating;
        public InputAction @StopRotating => m_Wrapper.m_Player_StopRotating;
        public InputAction @Rotate => m_Wrapper.m_Player_Rotate;
        public InputAction @StartJumping => m_Wrapper.m_Player_StartJumping;
        public InputAction @StopJumping => m_Wrapper.m_Player_StopJumping;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @StartMoving.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartMoving;
                @StartMoving.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartMoving;
                @StartMoving.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartMoving;
                @StopMoving.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopMoving;
                @StopMoving.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopMoving;
                @StopMoving.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopMoving;
                @StartRotating.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartRotating;
                @StartRotating.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartRotating;
                @StartRotating.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartRotating;
                @StopRotating.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopRotating;
                @StopRotating.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopRotating;
                @StopRotating.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopRotating;
                @Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @StartJumping.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartJumping;
                @StartJumping.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartJumping;
                @StartJumping.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStartJumping;
                @StopJumping.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopJumping;
                @StopJumping.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopJumping;
                @StopJumping.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopJumping;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @StartMoving.started += instance.OnStartMoving;
                @StartMoving.performed += instance.OnStartMoving;
                @StartMoving.canceled += instance.OnStartMoving;
                @StopMoving.started += instance.OnStopMoving;
                @StopMoving.performed += instance.OnStopMoving;
                @StopMoving.canceled += instance.OnStopMoving;
                @StartRotating.started += instance.OnStartRotating;
                @StartRotating.performed += instance.OnStartRotating;
                @StartRotating.canceled += instance.OnStartRotating;
                @StopRotating.started += instance.OnStopRotating;
                @StopRotating.performed += instance.OnStopRotating;
                @StopRotating.canceled += instance.OnStopRotating;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @StartJumping.started += instance.OnStartJumping;
                @StartJumping.performed += instance.OnStartJumping;
                @StartJumping.canceled += instance.OnStartJumping;
                @StopJumping.started += instance.OnStopJumping;
                @StopJumping.performed += instance.OnStopJumping;
                @StopJumping.canceled += instance.OnStopJumping;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnStartMoving(InputAction.CallbackContext context);
        void OnStopMoving(InputAction.CallbackContext context);
        void OnStartRotating(InputAction.CallbackContext context);
        void OnStopRotating(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnStartJumping(InputAction.CallbackContext context);
        void OnStopJumping(InputAction.CallbackContext context);
    }
}
