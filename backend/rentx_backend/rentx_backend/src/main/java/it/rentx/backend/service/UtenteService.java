package it.rentx.backend.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import it.rentx.backend.models.Utente;

@Service
public class UtenteService {
	
	@Autowired
	private PasswordEncoder passwordEncoder;
	
	public Utente encodePassword(Utente utente) {
		String note_encoded_password = utente.getPassword();
		// Encoding password
		String encoded_password = this.passwordEncoder.encode(note_encoded_password);
		// Set encoded password
		utente.setPassword(encoded_password);
		return utente;
	}
	
	public Boolean checkPassword(String pwd_db, String pwd_body) {
		return this.passwordEncoder.matches(pwd_body, pwd_db);
	}
	
}