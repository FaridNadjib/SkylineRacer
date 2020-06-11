// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Ship"",
            ""id"": ""19f71f54-745e-4fe4-b703-bd8474144059"",
            ""actions"": [
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5e905165-c3a2-4852-bc29-49d34dcb2663"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ed2f8581-9d1b-4283-900a-e68fa92ae2df"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b28d0517-1d97-4d0b-9201-796cb332ab33"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveUp"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9627c8e6-f3cd-40b7-952d-4dc2c052a8e1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraRotation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""aaba9ea8-ee42-432a-a756-f8024dc625ca"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootLaser"",
                    ""type"": ""Button"",
                    ""id"": ""5e3e9ba5-aa09-41ce-8a27-ff3616e63619"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootRocket"",
                    ""type"": ""Button"",
                    ""id"": ""cb735cb2-109c-4c18-b124-45a4997e7375"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""RT/LT"",
                    ""id"": ""127ae5a9-b346-410e-917d-d62682f52c3d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""395c6bd3-c5e9-4a39-a5c1-6a24a847ea92"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e52019ce-5255-4a0a-bc3c-c0b60ce35159"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2bc675be-50e9-4b37-9463-b22b28b3c238"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27e0b357-1c2b-4902-8f7f-5258d512f3fd"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d29cebc2-4840-46fb-ae80-b677fe6f6712"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""RB/LB"",
                    ""id"": ""1474e3b2-9ed1-447b-b687-3c61e764b258"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""caaace72-11bc-4e85-80bb-8d23e35f06ad"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bc4e3b3c-eba1-4804-899a-1fdd6f8cc3c3"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""46582b62-3ed4-4504-88bb-23857b750f09"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""D-PadUpDown"",
                    ""id"": ""94055820-395d-4427-93c8-44bbacca6700"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUp"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b8cec5db-8af0-4157-a169-1ca851aef8fc"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a87ee303-451c-4644-b28f-84af38e23185"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ff4a7a5a-cb95-403d-8a78-45f4fa823195"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1e17da4-bdf2-4878-b74e-344759187d78"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShootLaser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12bdeaf2-8cce-4733-9677-ad22e2d01a88"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ShootRocket"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""63ca4e3b-60f3-4809-88a2-38d88826088e"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""e511a31e-7cee-4404-9aff-7aef763096be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""79c710aa-6276-4593-88bd-5394c0b0c423"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Ship
        m_Ship = asset.FindActionMap("Ship", throwIfNotFound: true);
        m_Ship_Accelerate = m_Ship.FindAction("Accelerate", throwIfNotFound: true);
        m_Ship_Rotate = m_Ship.FindAction("Rotate", throwIfNotFound: true);
        m_Ship_Roll = m_Ship.FindAction("Roll", throwIfNotFound: true);
        m_Ship_MoveUp = m_Ship.FindAction("MoveUp", throwIfNotFound: true);
        m_Ship_CameraRotation = m_Ship.FindAction("CameraRotation", throwIfNotFound: true);
        m_Ship_ShootLaser = m_Ship.FindAction("ShootLaser", throwIfNotFound: true);
        m_Ship_ShootRocket = m_Ship.FindAction("ShootRocket", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Newaction = m_UI.FindAction("New action", throwIfNotFound: true);
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

    // Ship
    private readonly InputActionMap m_Ship;
    private IShipActions m_ShipActionsCallbackInterface;
    private readonly InputAction m_Ship_Accelerate;
    private readonly InputAction m_Ship_Rotate;
    private readonly InputAction m_Ship_Roll;
    private readonly InputAction m_Ship_MoveUp;
    private readonly InputAction m_Ship_CameraRotation;
    private readonly InputAction m_Ship_ShootLaser;
    private readonly InputAction m_Ship_ShootRocket;
    public struct ShipActions
    {
        private @PlayerInputActions m_Wrapper;
        public ShipActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accelerate => m_Wrapper.m_Ship_Accelerate;
        public InputAction @Rotate => m_Wrapper.m_Ship_Rotate;
        public InputAction @Roll => m_Wrapper.m_Ship_Roll;
        public InputAction @MoveUp => m_Wrapper.m_Ship_MoveUp;
        public InputAction @CameraRotation => m_Wrapper.m_Ship_CameraRotation;
        public InputAction @ShootLaser => m_Wrapper.m_Ship_ShootLaser;
        public InputAction @ShootRocket => m_Wrapper.m_Ship_ShootRocket;
        public InputActionMap Get() { return m_Wrapper.m_Ship; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipActions set) { return set.Get(); }
        public void SetCallbacks(IShipActions instance)
        {
            if (m_Wrapper.m_ShipActionsCallbackInterface != null)
            {
                @Accelerate.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnAccelerate;
                @Rotate.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnRotate;
                @Roll.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnRoll;
                @MoveUp.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnMoveUp;
                @MoveUp.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnMoveUp;
                @MoveUp.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnMoveUp;
                @CameraRotation.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnCameraRotation;
                @ShootLaser.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnShootLaser;
                @ShootLaser.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnShootLaser;
                @ShootLaser.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnShootLaser;
                @ShootRocket.started -= m_Wrapper.m_ShipActionsCallbackInterface.OnShootRocket;
                @ShootRocket.performed -= m_Wrapper.m_ShipActionsCallbackInterface.OnShootRocket;
                @ShootRocket.canceled -= m_Wrapper.m_ShipActionsCallbackInterface.OnShootRocket;
            }
            m_Wrapper.m_ShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @MoveUp.started += instance.OnMoveUp;
                @MoveUp.performed += instance.OnMoveUp;
                @MoveUp.canceled += instance.OnMoveUp;
                @CameraRotation.started += instance.OnCameraRotation;
                @CameraRotation.performed += instance.OnCameraRotation;
                @CameraRotation.canceled += instance.OnCameraRotation;
                @ShootLaser.started += instance.OnShootLaser;
                @ShootLaser.performed += instance.OnShootLaser;
                @ShootLaser.canceled += instance.OnShootLaser;
                @ShootRocket.started += instance.OnShootRocket;
                @ShootRocket.performed += instance.OnShootRocket;
                @ShootRocket.canceled += instance.OnShootRocket;
            }
        }
    }
    public ShipActions @Ship => new ShipActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Newaction;
    public struct UIActions
    {
        private @PlayerInputActions m_Wrapper;
        public UIActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_UI_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IShipActions
    {
        void OnAccelerate(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnMoveUp(InputAction.CallbackContext context);
        void OnCameraRotation(InputAction.CallbackContext context);
        void OnShootLaser(InputAction.CallbackContext context);
        void OnShootRocket(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
