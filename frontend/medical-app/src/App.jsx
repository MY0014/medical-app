import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from './assets/vite.svg'
import heroImg from './assets/hero.png'
import "./App.css";

function App() {
  return (
      <div className="login-page">
        <div className="login-container">

          <div className="welcome-section">
            <div className="welcome-content">
              <div className="logo">
                <div className="logo-icon">♥</div>
                <div>
                  <h2>Medical-App</h2>
                  <span>Manejo de citas</span>
                </div>
              </div>
              <div className="welcome-text">
                <h3></h3>
                <p>
                </p>
              </div>
            </div>
            <div className="circle circle-one"></div>
            <div className="circle circle-two"></div>
            <div className="circle circle-three"></div>
          </div>
          <div className="form-section">
            <div className="form-container">
              <h1>Inicio Sesion</h1>
              <p className="form-description">
              </p>
              <form>
                <div className="input-group">
                  <span className="input-icon">👤</span>
                  <input
                      type="text"
                      placeholder="Usuario o correo"
                  />
                </div>
                <div className="input-group">
                  <span className="input-icon">🔒</span>

                  <input
                      type="password"
                      placeholder="Clave"
                  />
                  <button
                      type="button"
                      className="show-button"
                  >
                    Mostrar
                  </button>
                </div>
                <div className="form-options">
                  <label>
                    <input type="checkbox" />
                    <span>Recordar datos</span>
                  </label>

                  <a href="#">
                    Olvidaste tu clave?
                  </a>
                </div>
                <button
                    type="submit"
                    className="login-button"
                >
                  Iniciar sesion
                </button>
              </form>
              <div className="divider">
                <span></span>
                <p>o</p>
                <span></span>
              </div>
              <button className="google-button">
                <span className="google-icon">G</span>
                Iniciar con google
              </button>
              <p className="register-text">
                No tiene cuenta?
                <a href="#"> Crear una</a>
              </p>
            </div>
          </div>
        </div>
      </div>
  );
}

export default App;