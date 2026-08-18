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
                  <h2>Medicall-App</h2>
                  <span>Appointments</span>
                </div>
              </div>

              <div className="welcome-text">
                <h3>TO YOUR HEALTH JOURNEY</h3>
                <p>
                  Book appointments with top doctors, manage
                  your schedule and payments, and get the best
                  healthcare experience all in one place.
                </p>
              </div>

            </div>

            <div className="circle circle-one"></div>
            <div className="circle circle-two"></div>
            <div className="circle circle-three"></div>
          </div>

          <div className="form-section">

            <div className="form-container">

              <h1>Sign in</h1>

              <p className="form-description">

              </p>
              <form>
                <div className="input-group">
                  <span className="input-icon">👤</span>

                  <input
                      type="text"
                      placeholder="User name or email"
                  />
                </div>

                <div className="input-group">
                  <span className="input-icon">🔒</span>

                  <input
                      type="password"
                      placeholder="Password"
                  />

                  <button
                      type="button"
                      className="show-button"
                  >
                    SHOW
                  </button>
                </div>

                <div className="form-options">

                  <label>
                    <input type="checkbox" />
                    <span>Remember me</span>
                  </label>

                  <a href="#">
                    Forgot password?
                  </a>

                </div>

                <button
                    type="submit"
                    className="login-button"
                >
                  Sign in
                </button>

              </form>

              <div className="divider">
                <span></span>
                <p>or</p>
                <span></span>
              </div>

              <button className="google-button">
                <span className="google-icon">G</span>
                Sign in with Google
              </button>

              <p className="register-text">
                Don't have an account?
                <a href="#"> Sign up</a>
              </p>

            </div>

          </div>

        </div>
      </div>
  );
}

export default App;