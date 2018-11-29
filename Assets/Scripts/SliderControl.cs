using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{

    public GameObject cube;
    public GameObject cylinder;
    public GameObject plane;
    public GameObject sphere;

    public Toggle toggleCube;
    public Toggle toggleCylinder;
    public Toggle togglePlane;
    public Toggle toggleSphere;

    public void SliderPXValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubePosition = cube.transform.position;
            cubePosition.x = newValue;
            cube.transform.position = cubePosition;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderPosition = cylinder.transform.position;
            cylinderPosition.x = newValue;
            cylinder.transform.position = cylinderPosition;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planePosition = plane.transform.position;
            planePosition.x = newValue;
            plane.transform.position = planePosition;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 spherePosition = sphere.transform.position;
            spherePosition.x = newValue;
            sphere.transform.position = spherePosition;
        }
    }

    public void SliderPYValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubePosition = cube.transform.position;
            cubePosition.y = newValue;
            cube.transform.position = cubePosition;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderPosition = cylinder.transform.position;
            cylinderPosition.y = newValue;
            cylinder.transform.position = cylinderPosition;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planePosition = plane.transform.position;
            planePosition.y = newValue;
            plane.transform.position = planePosition;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 spherePosition = sphere.transform.position;
            spherePosition.y = newValue;
            sphere.transform.position = spherePosition;
        }
    }

    public void SliderPZValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubePosition = cube.transform.position;
            cubePosition.z = newValue;
            cube.transform.position = cubePosition;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderPosition = cylinder.transform.position;
            cylinderPosition.z = newValue;
            cylinder.transform.position = cylinderPosition;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planePosition = plane.transform.position;
            planePosition.z = newValue;
            plane.transform.position = planePosition;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 spherePosition = sphere.transform.position;
            spherePosition.z = newValue;
            sphere.transform.position = spherePosition;
        }
    }

    public void SliderRXValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubeRotation = cube.transform.eulerAngles;
            cubeRotation.x = newValue;
            cube.transform.eulerAngles = cubeRotation;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderRotation = cylinder.transform.eulerAngles;
            cylinderRotation.x = newValue;
            cylinder.transform.eulerAngles = cylinderRotation;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planeRotation = plane.transform.eulerAngles;
            planeRotation.x = newValue;
            plane.transform.eulerAngles = planeRotation;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 sphereRotation = sphere.transform.eulerAngles;
            sphereRotation.x = newValue;
            sphere.transform.eulerAngles = sphereRotation;
        }
    }

    public void SliderRYValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubeRotation = cube.transform.eulerAngles;
            cubeRotation.y = newValue;
            cube.transform.eulerAngles = cubeRotation;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderRotation = cylinder.transform.eulerAngles;
            cylinderRotation.y = newValue;
            cylinder.transform.eulerAngles = cylinderRotation;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planeRotation = plane.transform.eulerAngles;
            planeRotation.y = newValue;
            plane.transform.eulerAngles = planeRotation;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 sphereRotation = sphere.transform.eulerAngles;
            sphereRotation.y = newValue;
            sphere.transform.eulerAngles = sphereRotation;
        }
    }

    public void SliderRZValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubeRotation = cube.transform.eulerAngles;
            cubeRotation.z = newValue;
            cube.transform.eulerAngles = cubeRotation;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderRotation = cylinder.transform.eulerAngles;
            cylinderRotation.z = newValue;
            cylinder.transform.eulerAngles = cylinderRotation;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planeRotation = plane.transform.eulerAngles;
            planeRotation.z = newValue;
            plane.transform.eulerAngles = planeRotation;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 sphereRotation = sphere.transform.eulerAngles;
            sphereRotation.z = newValue;
            sphere.transform.eulerAngles = sphereRotation;
        }
    }

    public void SliderSXValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubeScale = cube.transform.localScale;
            cubeScale.x = newValue;
            cube.transform.localScale = cubeScale;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderScale = cylinder.transform.localScale;
            cylinderScale.x = newValue;
            cylinder.transform.localScale = cylinderScale;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planeScale = plane.transform.localScale;
            planeScale.x = newValue / 5;
            plane.transform.localScale = planeScale;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 sphereScale = sphere.transform.localScale;
            sphereScale.x = newValue;
            sphere.transform.localScale = sphereScale;
        }
    }

    public void SliderSYValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubeScale = cube.transform.localScale;
            cubeScale.y = newValue;
            cube.transform.localScale = cubeScale;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderScale = cylinder.transform.localScale;
            cylinderScale.y = newValue;
            cylinder.transform.localScale = cylinderScale;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planeScale = plane.transform.localScale;
            planeScale.y = newValue / 5;
            plane.transform.localScale = planeScale;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 sphereScale = sphere.transform.localScale;
            sphereScale.y = newValue;
            sphere.transform.localScale = sphereScale;
        }
    }

    public void SliderSZValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubeScale = cube.transform.localScale;
            cubeScale.z = newValue;
            cube.transform.localScale = cubeScale;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderScale = cylinder.transform.localScale;
            cylinderScale.z = newValue;
            cylinder.transform.localScale = cylinderScale;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planeScale = plane.transform.localScale;
            planeScale.z = newValue / 5;
            plane.transform.localScale = planeScale;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 sphereScale = sphere.transform.localScale;
            sphereScale.z = newValue;
            sphere.transform.localScale = sphereScale;
        }
    }

}

