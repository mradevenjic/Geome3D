using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{

    public GameObject cube;
    public GameObject cylinder;
    public GameObject plane;
    public GameObject sphere;
    public GameObject cone;
    public GameObject pyramid;

    public Toggle toggleCube;
    public Toggle toggleCylinder;
    public Toggle togglePlane;
    public Toggle toggleSphere;
    public Toggle toggleCone;
    public Toggle togglePyramid;

    public void SliderPXValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubePosition = cube.transform.position;
            cubePosition.x = newValue / 2;
            cube.transform.position = cubePosition;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderPosition = cylinder.transform.position;
            cylinderPosition.x = newValue / 2;
            cylinder.transform.position = cylinderPosition;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planePosition = plane.transform.position;
            planePosition.x = newValue / 2;
            plane.transform.position = planePosition;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 spherePosition = sphere.transform.position;
            spherePosition.x = newValue / 2;
            sphere.transform.position = spherePosition;
        }

        if (toggleCone.isOn == true)
        {
            Vector3 conePosition = cone.transform.position;
            conePosition.x = newValue / 2;
            cone.transform.position = conePosition;
        }

        if (togglePyramid.isOn == true)
        {
            Vector3 pyramidPosition = pyramid.transform.position;
            pyramidPosition.x = newValue / 2;
            pyramid.transform.position = pyramidPosition;
        }
    }

    public void SliderPYValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubePosition = cube.transform.position;
            cubePosition.y = newValue / 2;
            cube.transform.position = cubePosition;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderPosition = cylinder.transform.position;
            cylinderPosition.y = newValue / 2;
            cylinder.transform.position = cylinderPosition;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planePosition = plane.transform.position;
            planePosition.y = newValue / 2;
            plane.transform.position = planePosition;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 spherePosition = sphere.transform.position;
            spherePosition.y = newValue / 2;
            sphere.transform.position = spherePosition;
        }

        if (toggleCone.isOn == true)
        {
            Vector3 conePosition = cone.transform.position;
            conePosition.y = newValue / 2;
            cone.transform.position = conePosition;
        }

        if (togglePyramid.isOn == true)
        {
            Vector3 pyramidPosition = pyramid.transform.position;
            pyramidPosition.y = newValue / 2;
            pyramid.transform.position = pyramidPosition;
        }
    }

    public void SliderPZValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubePosition = cube.transform.position;
            cubePosition.z = newValue / 2;
            cube.transform.position = cubePosition;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderPosition = cylinder.transform.position;
            cylinderPosition.z = newValue / 2;
            cylinder.transform.position = cylinderPosition;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planePosition = plane.transform.position;
            planePosition.z = newValue / 2;
            plane.transform.position = planePosition;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 spherePosition = sphere.transform.position;
            spherePosition.z = newValue / 2;
            sphere.transform.position = spherePosition;
        }

        if (toggleCone.isOn == true)
        {
            Vector3 conePosition = cone.transform.position;
            conePosition.z = newValue / 2;
            cone.transform.position = conePosition;
        }

        if (togglePyramid.isOn == true)
        {
            Vector3 pyramidPosition = pyramid.transform.position;
            pyramidPosition.z = newValue / 2;
            pyramid.transform.position = pyramidPosition;
        }
    }

    public void SliderRXValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubeRotation = cube.transform.eulerAngles;
            cubeRotation.x = newValue * 5;
            cube.transform.eulerAngles = cubeRotation;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderRotation = cylinder.transform.eulerAngles;
            cylinderRotation.x = newValue * 5;
            cylinder.transform.eulerAngles = cylinderRotation;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planeRotation = plane.transform.eulerAngles;
            planeRotation.x = newValue * 5;
            plane.transform.eulerAngles = planeRotation;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 sphereRotation = sphere.transform.eulerAngles;
            sphereRotation.x = newValue * 5;
            sphere.transform.eulerAngles = sphereRotation;
        }

        if (toggleCone.isOn == true)
        {
            Vector3 coneRotation = cone.transform.eulerAngles;
            coneRotation.x = newValue * 5;
            cone.transform.eulerAngles = coneRotation;
        }

        if (togglePyramid.isOn == true)
        {
            Vector3 pyramidRotation = pyramid.transform.eulerAngles;
            pyramidRotation.x = newValue * 5;
            pyramid.transform.eulerAngles = pyramidRotation;
        }
    }

    public void SliderRYValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubeRotation = cube.transform.eulerAngles;
            cubeRotation.y = newValue * 5;
            cube.transform.eulerAngles = cubeRotation;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderRotation = cylinder.transform.eulerAngles;
            cylinderRotation.y = newValue * 5;
            cylinder.transform.eulerAngles = cylinderRotation;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planeRotation = plane.transform.eulerAngles;
            planeRotation.y = newValue * 5;
            plane.transform.eulerAngles = planeRotation;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 sphereRotation = sphere.transform.eulerAngles;
            sphereRotation.y = newValue * 5;
            sphere.transform.eulerAngles = sphereRotation;
        }

        if (toggleCone.isOn == true)
        {
            Vector3 coneRotation = cone.transform.eulerAngles;
            coneRotation.y = newValue * 5;
            cone.transform.eulerAngles = coneRotation;
        }

        if (togglePyramid.isOn == true)
        {
            Vector3 pyramidRotation = pyramid.transform.eulerAngles;
            pyramidRotation.y = newValue * 5;
            pyramid.transform.eulerAngles = pyramidRotation;
        }
    }

    public void SliderRZValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubeRotation = cube.transform.eulerAngles;
            cubeRotation.z = newValue * 5;
            cube.transform.eulerAngles = cubeRotation;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderRotation = cylinder.transform.eulerAngles;
            cylinderRotation.z = newValue * 5;
            cylinder.transform.eulerAngles = cylinderRotation;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planeRotation = plane.transform.eulerAngles;
            planeRotation.z = newValue * 5;
            plane.transform.eulerAngles = planeRotation;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 sphereRotation = sphere.transform.eulerAngles;
            sphereRotation.z = newValue * 5;
            sphere.transform.eulerAngles = sphereRotation;
        }

        if (toggleCone.isOn == true)
        {
            Vector3 coneRotation = cone.transform.eulerAngles;
            coneRotation.z = newValue * 5;
            cone.transform.eulerAngles = coneRotation;
        }

        if (togglePyramid.isOn == true)
        {
            Vector3 pyramidRotation = pyramid.transform.eulerAngles;
            pyramidRotation.z = newValue * 5;
            pyramid.transform.eulerAngles = pyramidRotation;
        }
    }

    public void SliderSXValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubeScale = cube.transform.localScale;
            cubeScale.x = newValue / 5;
            cube.transform.localScale = cubeScale;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderScale = cylinder.transform.localScale;
            cylinderScale.x = newValue / 5;
            cylinder.transform.localScale = cylinderScale;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planeScale = plane.transform.localScale;
            planeScale.x = newValue / 50;
            plane.transform.localScale = planeScale;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 sphereScale = sphere.transform.localScale;
            sphereScale.x = newValue / 5;
            sphere.transform.localScale = sphereScale;
        }

        if (toggleCone.isOn == true)
        {
            Vector3 coneScale = cone.transform.localScale;
            coneScale.x = newValue / 10;
            cone.transform.localScale = coneScale;
        }

        if (togglePyramid.isOn == true)
        {
            Vector3 pyramidScale = pyramid.transform.localScale;
            pyramidScale.x = newValue / 10;
            pyramid.transform.localScale = pyramidScale;
        }
    }

    public void SliderSYValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubeScale = cube.transform.localScale;
            cubeScale.y = newValue / 5;
            cube.transform.localScale = cubeScale;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderScale = cylinder.transform.localScale;
            cylinderScale.y = newValue / 10;
            cylinder.transform.localScale = cylinderScale;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planeScale = plane.transform.localScale;
            planeScale.y = newValue / 50;
            plane.transform.localScale = planeScale;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 sphereScale = sphere.transform.localScale;
            sphereScale.y = newValue / 5;
            sphere.transform.localScale = sphereScale;
        }

        if (toggleCone.isOn == true)
        {
            Vector3 coneScale = cone.transform.localScale;
            coneScale.y = newValue / 10;
            cone.transform.localScale = coneScale;
        }

        if (togglePyramid.isOn == true)
        {
            Vector3 pyramidScale = pyramid.transform.localScale;
            pyramidScale.y = newValue / 10;
            pyramid.transform.localScale = pyramidScale;
        }
    }

    public void SliderSZValueChanged(float newValue)
    {
        if (toggleCube.isOn == true)
        {
            Vector3 cubeScale = cube.transform.localScale;
            cubeScale.z = newValue / 5;
            cube.transform.localScale = cubeScale;
        }

        if (toggleCylinder.isOn == true)
        {
            Vector3 cylinderScale = cylinder.transform.localScale;
            cylinderScale.z = newValue / 5;
            cylinder.transform.localScale = cylinderScale;
        }

        if (togglePlane.isOn == true)
        {
            Vector3 planeScale = plane.transform.localScale;
            planeScale.z = newValue / 50;
            plane.transform.localScale = planeScale;
        }

        if (toggleSphere.isOn == true)
        {
            Vector3 sphereScale = sphere.transform.localScale;
            sphereScale.z = newValue / 5;
            sphere.transform.localScale = sphereScale;
        }

        if (toggleCone.isOn == true)
        {
            Vector3 coneScale = cone.transform.localScale;
            coneScale.z = newValue / 10;
            cone.transform.localScale = coneScale;
        }

        if (togglePyramid.isOn == true)
        {
            Vector3 pyramidScale = pyramid.transform.localScale;
            pyramidScale.z = newValue / 10;
            pyramid.transform.localScale = pyramidScale;
        }
    }

}

